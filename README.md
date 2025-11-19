# CSV Daten Analyzer - Blazor App

## 🚀 Anwendung starten

Klicke hier, um die Anwendung direkt im Browser zu öffnen:

👉 **[CSV-Daten-Analyzer starten](https://etlasso.github.io/CSV-Daten-Analyzer/)**  

Eine einfache Webanwendung zum Hochladen, Anzeigen und Visualisieren von CSV-Dateien als interaktive Diagramme.

## Hauptfunktionen
- CSV-Dateien per Upload oder Dateipfad laden
- Automatische Erkennung der Kopfzeile
- Unterstützt Komma- und Semikolon-Trennzeichen
- Mehrere Dateien parallel verwalten
- Visualisierung als Linien-, Balken- oder Flächendiagramme
- Interaktive Charts mit Zoom und Tooltips
- Rohdaten als Tabelle anzeigen (erste 100 Zeilen)

## Benutzung
1. Im Menü „CSV Viewer“ eine Datei hochladen oder Pfad eingeben.
2. Datei auswählen und Chart-Typ sowie Achsen konfigurieren.
3. Chart anzeigen lassen und Daten darunter sehen.

## Technik
- .NET 8.0 / Blazor Server
- CsvHelper für CSV-Verarbeitung
- Chart.js für Diagramme
- Bootstrap für UI

## Voraussetzungen
- Visual Studio 2022 oder neuer
- .NET 8 SDK

## Problembehandlung
- Nur CSV-Dateien mit Komma oder Semikolon als Trenner verwenden
- Datei muss Kopfzeile haben
- Für Charts müssen numerische Spalten ausgewählt werden
- Dateipfade korrekt mit Backslashes angeben
