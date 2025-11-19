namespace csv_1.Models
{
    public class CsvDataSet
    {
        public string FileName { get; set; } = string.Empty;
        public DateTime UploadDate { get; set; }
        public List<string> Headers { get; set; } = new();
        public List<Dictionary<string, string>> Rows { get; set; } = new();
        public int RowCount => Rows.Count;
    }

    public class ChartConfiguration
    {
        public string Title { get; set; } = "CSV Daten Visualisierung";
        public string XAxisColumn { get; set; } = string.Empty;
        public List<string> YAxisColumns { get; set; } = new();
        public string ChartType { get; set; } = "line"; // line, bar, pie
    }
}
