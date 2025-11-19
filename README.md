# CSV Daten Analyzer - Blazor Anwendung

## Übersicht
Diese Blazor-Anwendung ermöglicht das Einlesen, Speichern und Visualisieren von CSV-Dateien mit interaktiven Charts.

## Features

### 1. CSV-Datei Import
- **Datei-Upload**: Laden Sie CSV-Dateien direkt über die Benutzeroberfläche hoch
- **Dateipfad-Eingabe**: Geben Sie einen lokalen Dateipfad ein (z.B. `C:\Daten\meine_datei.csv`)
- **Flexible Delimiter**: Unterstützt sowohl Komma (,) als auch Semikolon (;) als Trennzeichen
- **Automatische Header-Erkennung**: Die erste Zeile wird automatisch als Header erkannt

### 2. Datenverwaltung
- Mehrere CSV-Dateien gleichzeitig laden und verwalten
- Übersicht aller geladenen Dateien mit Zeilen- und Spaltenanzahl
- Zeitstempel für jeden Import
- Dateien können einzeln entfernt werden

### 3. Datenvisualisierung
- **Chart-Typen**: 
  - Liniendiagramm
  - Balkendiagramm
  - Flächendiagramm
- **Flexible Achsen-Konfiguration**:
  - X-Achse: Wählen Sie eine beliebige Spalte
  - Y-Achse: Wählen Sie mehrere Spalten zur Darstellung
- **Interaktive Charts**: Powered by Chart.js mit Tooltips und Zoom-Funktionen

### 4. Datenansicht
- Tabellarische Ansicht der Rohdaten
- Zeigt die ersten 100 Zeilen an
- Scrollbare Tabelle mit fixiertem Header

## Technologie-Stack
- **.NET 8.0**
- **Blazor Server**
- **CsvHelper** - CSV-Parsing
- **Chart.js** - Datenvisualisierung
- **Bootstrap 5** - UI-Framework
- **Bootstrap Icons** - Icons

## Installation & Ausführung

### Voraussetzungen
- Visual Studio 2022 (oder neuer)
- .NET 8.0 SDK

### Schritte

1. **Projekt öffnen**
   ```
   Öffnen Sie die Solution: csv 1.sln in Visual Studio
   ```

2. **NuGet-Pakete wiederherstellen**
   ```
   Visual Studio -> Rechtsklick auf Solution -> "NuGet-Pakete wiederherstellen"
   ```

3. **Projekt ausführen**
   ```
   F5 drücken oder auf "Start" klicken
   ```

4. **Browser öffnen**
   ```
   Die Anwendung startet automatisch im Browser (üblicherweise https://localhost:7xxx)
   ```

## Verwendung

### CSV-Datei laden

**Methode 1: Datei-Upload**
1. Navigieren Sie zu "CSV Viewer" im Menü
2. Klicken Sie auf "Datei hochladen" und wählen Sie eine CSV-Datei
3. Die Datei wird automatisch geladen und analysiert

**Methode 2: Dateipfad**
1. Geben Sie den vollständigen Pfad zur CSV-Datei ein
   Beispiel: `C:\Users\Administrator\source\repos\csv 1\Realisierte_Erzeugung_20202025_Stunde.csv`
2. Klicken Sie auf "Laden"

### Chart erstellen

1. Wählen Sie eine geladene Datei aus (Klick auf "Anzeigen")
2. Konfigurieren Sie den Chart:
   - **Chart-Typ** auswählen (Linien, Balken, Fläche)
   - **X-Achse** auswählen (z.B. Datum/Zeit-Spalte)
   - **Y-Achse** auswählen (eine oder mehrere Datenspalten)
3. Klicken Sie auf "Chart aktualisieren"

### Daten anzeigen
- Die Rohdaten werden automatisch unterhalb des Charts angezeigt
- Scrollen Sie durch die Tabelle, um alle Daten zu sehen

## Projektstruktur

```
csv 1/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor       # Haupt-Layout
│   │   └── NavMenu.razor          # Navigation
│   ├── Pages/
│   │   ├── Home.razor             # Startseite
│   │   └── CsvViewer.razor        # CSV Viewer Hauptseite
│   └── App.razor                  # Root-Komponente
├── Models/
│   └── CsvDataSet.cs              # Datenmodelle
├── Services/
│   └── CsvService.cs              # CSV-Verarbeitungs-Service
├── wwwroot/
│   ├── chart-handler.js           # Chart.js Integration
│   └── app.css                    # Styles
└── Program.cs                     # Startup-Konfiguration
```

## Unterstützte CSV-Formate

Die Anwendung unterstützt:
- **Encoding**: UTF-8, UTF-8 with BOM
- **Delimiter**: Komma (,) oder Semikolon (;)
- **Header**: Erste Zeile wird als Header verwendet
- **Dateigröße**: Bis zu 50 MB

## Beispiel CSV-Struktur

```csv
Datum,Biomasse,Wasserkraft,Wind Offshore,Wind Onshore
01.01.2020 00:00,4863,1914,0,4958
01.01.2020 01:00,4819,1921,0,5241
01.01.2020 02:00,4799,1927,0,5499
```

## Troubleshooting

### Problem: CSV wird nicht geladen
- **Lösung**: Überprüfen Sie, ob die Datei das richtige Format hat (CSV mit Komma oder Semikolon)
- **Lösung**: Stellen Sie sicher, dass die erste Zeile Header-Namen enthält

### Problem: Chart wird nicht angezeigt
- **Lösung**: Wählen Sie mindestens eine X-Achse und eine Y-Achse aus
- **Lösung**: Stellen Sie sicher, dass die Y-Achsen-Spalten numerische Werte enthalten

### Problem: Dateipfad funktioniert nicht
- **Lösung**: Verwenden Sie den vollständigen Pfad mit Backslashes: `C:\Ordner\datei.csv`
- **Lösung**: Stellen Sie sicher, dass die Datei existiert und lesbar ist

## Erweiterungsmöglichkeiten

Mögliche zukünftige Features:
- Export von Charts als PNG/PDF
- Datenfilterung und -sortierung
- Statistische Analysen (Durchschnitt, Min, Max)
- Unterstützung für Excel-Dateien (.xlsx)
- Daten-Editor zum direkten Bearbeiten von Werten
- Mehrere Charts gleichzeitig anzeigen
- Speichern von Chart-Konfigurationen

## Lizenz
Dieses Projekt ist für den internen Gebrauch bestimmt.

## Autor
Erstellt mit Claude AI Assistant
