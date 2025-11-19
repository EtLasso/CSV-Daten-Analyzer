using csv_1.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace csv_1.Services
{
    public class CsvService
    {
        private readonly List<CsvDataSet> _dataSets = new();

        public List<CsvDataSet> GetAllDataSets() => _dataSets;

        public async Task<CsvDataSet?> LoadCsvFromStreamAsync(Stream stream, string fileName)
        {
            try
            {
                var dataSet = new CsvDataSet
                {
                    FileName = fileName,
                    UploadDate = DateTime.Now
                };

                // Lese die gesamte Datei erstmal als String
                using var reader = new StreamReader(stream, Encoding.UTF8, detectEncodingFromByteOrderMarks: true);
                var content = await reader.ReadToEndAsync();
                
                // Entferne BOM falls vorhanden
                if (content.StartsWith("\uFEFF"))
                {
                    content = content.Substring(1);
                }

                // Erkenne Delimiter
                var delimiter = DetectDelimiter(content);
                Console.WriteLine($"Erkannter Delimiter: '{delimiter}'");

                // Erstelle Stream aus bereinigtem Content
                using var cleanStream = new MemoryStream(Encoding.UTF8.GetBytes(content));
                using var cleanReader = new StreamReader(cleanStream);

                // Konfiguration für deutsches CSV-Format
                var config = new CsvConfiguration(new CultureInfo("de-DE"))
                {
                    HasHeaderRecord = true,
                    Delimiter = delimiter,
                    BadDataFound = null,
                    MissingFieldFound = null,
                    TrimOptions = TrimOptions.Trim,
                    IgnoreBlankLines = true
                };

                using var csv = new CsvReader(cleanReader, config);
                
                // Header lesen
                await csv.ReadAsync();
                csv.ReadHeader();
                
                if (csv.HeaderRecord != null)
                {
                    dataSet.Headers = csv.HeaderRecord.ToList();
                    Console.WriteLine($"Headers: {string.Join(", ", dataSet.Headers)}");
                }

                // Daten lesen
                int rowCount = 0;
                while (await csv.ReadAsync())
                {
                    var row = new Dictionary<string, string>();
                    foreach (var header in dataSet.Headers)
                    {
                        try
                        {
                            var value = csv.GetField(header);
                            row[header] = value ?? string.Empty;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Fehler beim Lesen von Spalte '{header}': {ex.Message}");
                            row[header] = string.Empty;
                        }
                    }
                    dataSet.Rows.Add(row);
                    rowCount++;
                }

                Console.WriteLine($"Erfolgreich {rowCount} Zeilen geladen");
                _dataSets.Add(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Laden der CSV: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return null;
            }
        }

        private string DetectDelimiter(string content)
        {
            // Prüfe die erste Zeile
            var firstLine = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? "";
            
            var semicolonCount = firstLine.Count(c => c == ';');
            var commaCount = firstLine.Count(c => c == ',');
            var tabCount = firstLine.Count(c => c == '\t');

            Console.WriteLine($"Delimiter-Analyse - Semikolon: {semicolonCount}, Komma: {commaCount}, Tab: {tabCount}");

            if (semicolonCount > commaCount && semicolonCount > tabCount)
                return ";";
            if (tabCount > commaCount && tabCount > semicolonCount)
                return "\t";
            return ",";
        }

        public async Task<CsvDataSet?> LoadCsvFromPathAsync(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Datei nicht gefunden: {filePath}");
                    return null;
                }

                Console.WriteLine($"Lade Datei: {filePath}");
                using var stream = File.OpenRead(filePath);
                var fileName = Path.GetFileName(filePath);
                return await LoadCsvFromStreamAsync(stream, fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Laden der Datei: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return null;
            }
        }

        public void RemoveDataSet(CsvDataSet dataSet)
        {
            _dataSets.Remove(dataSet);
        }

        public void ClearAllDataSets()
        {
            _dataSets.Clear();
        }
    }
}
