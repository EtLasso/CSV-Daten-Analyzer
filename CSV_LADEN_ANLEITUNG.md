# CSV-Datei laden - Anleitung

## Problem: "Fehler beim Laden der Datei"

Wenn dieser Fehler auftritt, gibt es mehrere Lösungsmöglichkeiten:

## Lösung 1: Vollständiger Dateipfad (EMPFOHLEN)

Verwenden Sie den **vollständigen Pfad** zur CSV-Datei:

### Beispiele für korrekte Pfade:

```
C:\Users\Administrator\Downloads\Realisierte_Erzeugung_2020-2025_Stunde.csv
C:\Daten\meine_datei.csv
D:\Projekte\daten.csv
```

### ⚠️ Wichtig:
- Verwenden Sie **Backslashes** (`\`), nicht Forward-Slashes (`/`)
- Geben Sie den **kompletten Pfad** an, nicht nur den Dateinamen
- Achten Sie auf die **korrekte Schreibweise** des Dateinamens

## Lösung 2: Datei in Projekt-Ordner kopieren

1. Kopieren Sie Ihre CSV-Datei in den Projekt-Ordner:
   ```
   C:\Users\Administrator\source\repos\csv 1\
   ```

2. Dann können Sie einfach den Dateinamen eingeben:
   ```
   Realisierte_Erzeugung_2020-2025_Stunde.csv
   ```

## Lösung 3: Datei-Upload verwenden

Verwenden Sie stattdessen den **"Datei auswählen"**-Button:
1. Klicken Sie auf "Datei auswählen"
2. Navigieren Sie zu Ihrer CSV-Datei
3. Wählen Sie die Datei aus
4. Die Datei wird automatisch geladen

## Unterstützte CSV-Formate

✅ **Unterstützt:**
- Semikolon (;) als Trennzeichen
- Komma (,) als Trennzeichen
- Tab als Trennzeichen
- Deutsches Zahlenformat (1.234,56)
- Englisches Zahlenformat (1,234.56)
- UTF-8 Encoding mit oder ohne BOM

✅ **Beispiel-Struktur:**
```csv
Datum;Wert1;Wert2;Wert3
01.01.2020;100,5;200,3;300,7
02.01.2020;110,2;205,1;310,5
```

## Fehlerbehebung

### Problem: Datei nicht gefunden
**Lösung:** Überprüfen Sie den Dateipfad auf Tippfehler

### Problem: Encoding-Fehler
**Lösung:** Speichern Sie die CSV als UTF-8

### Problem: Keine Daten sichtbar
**Lösung:** Stellen Sie sicher, dass die erste Zeile Header-Namen enthält

## Beispiel-Verwendung

1. **Dateipfad eingeben:**
   ```
   C:\Users\Administrator\Downloads\daten.csv
   ```
   ➡️ Klicken Sie auf "Laden"

2. **Datei erscheint in der Liste**
   ➡️ Klicken Sie auf "Anzeigen"

3. **Chart konfigurieren:**
   - Chart-Typ wählen
   - X-Achse auswählen (z.B. Datum)
   - Y-Achsen auswählen (Datenspalten)
   ➡️ Klicken Sie auf "Chart aktualisieren"

## Debugging-Informationen

Die Anwendung schreibt Debug-Informationen in die Browser-Konsole:
1. Drücken Sie `F12` in Ihrem Browser
2. Gehen Sie zum Tab "Konsole"
3. Hier sehen Sie detaillierte Fehlermeldungen

## Häufige Fehler

| Fehler | Ursache | Lösung |
|--------|---------|---------|
| "Datei nicht gefunden" | Falscher Pfad | Vollständigen Pfad verwenden |
| "Fehler beim Laden" | Falsches Format | CSV-Format überprüfen |
| "Keine Daten" | Kein Header | Erste Zeile muss Header enthalten |
