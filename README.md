# SWE-Projekt
----------------------------

## Zielstellung

Unser Projekt ist eine Datenanalyse im Bereich der Demographie. Wir wollen mit diesem Projekt mithilfe von entsprechenden Datensätzen Prognosen zur Bevölkerungsetwicklung in Deutschland erstellen und den zukünftigen Bedarf an KiTas, Schulen etc. ermitteln. 
Diese Daten wollen wir anschließend mit der vorhandenen Infrastruktur vergleichen. 
Dabei soll das Programm einfach auf andere Länder übertragen und um ähnliche Sachverhalte (z.B. Altersheime) ergänzt werden können.

Dazu sollen die Daten zunächst aus einer Datei eingelesen und in Objekten gespeichert werden, welche wiederum in einer Liste organisiert sind.
Wir wollen eine Sortierung nach verschiedenen Altersgruppen, Nationalität und systemrelevanten Berufen ermöglichen.
Die Visualisierung der Resultate soll dabei mithilfe von .NET Interactive realisiert werden.

Außerdem soll ein Vergleich zwischen verschiedenen Kategorien möglich sein wie zum Beispiel:
In Deutschland gibt es aktuell ... Menschen über 40 Jahre, d.h. in  ... Jahren werden voraussichlich ... Menschen pflegebedürftig sein.
Derzeit gibt es in Deutschland ... Altersheime mit durchschnittlicher Kapazität für ... Bewohner und ... Pflegekräfte von denen ...%  bis dahin altersbedingt in Rente sein werden, also ... (müssen mehr Heime gebaut / Fachkräfte angeworben werden oder besteht derzeit kein Handlungsbedarf etc.)

Bei der Kategorie Schule werden die Schüler anhand der Geburtenrate prognostiziert bei Prognosen in ferner Zukunft. Ein möglicher Zusatz für alle Bereiche könnte die Immigration sein, die wir als Faktor für Schüler, Lehrer, Pflegekräften etc. nutzen möchten.

Realisiert werden soll diese Prognose zunächst für einen Fall (Schulen oder Altersheime) und evtl. auch für ähnlich Zusammenhänge (KiTas, Krankenhäuser...).
Optional wäre auch das Einlesen auch aus anderen Dateiformaten zu ermöglichen.


## Benutzungsanleitung Funktionsweise des Programmes

Da wir ein möglichst individualisierbares Programm schreiben wollten, müssen vom Nutzer zunächst einige Parameter festgelegt werden.

Diese sind in einer *.txt-Datei wie folgt abzulegen:

    1-RangeAgeGroup: *ganze Zahl, die Spanne der Altersgruppen angibt*
    2-MinAge: *ganze Zahl, jüngstes Alter, bei Geburtenvorhersage negativ*
    3-MaxAge: *ganze Zahl, Alter der ältesten Person(en)*
    4-Filename for Agegroups total Population: *Name der csv-Datei in welcher die Anzahl der        Personen nach Alter gespeichert ist*
    5-Minimum working Age: *Mindestalter für arbeitende Personen*
    6-Maximum working Age: *Renteneintrittsalter*
    7-Profession1: *optional:Bezeichnung der zu untersuchenden Berufsgruppe*
    8-Filename for Agegroups Profession 1: *optional:Name der csv-Datei in welcher die Anzahl der Personen der Berufsgruppe nach Alter gespeichert ist*
    9-Type of buildings1: *zur Berufsgruppe gehörende Gebäudebezeichnung*
    10-Number of Buildings1: *ganze Zahl, Anzahl diese Gebäude*
    11-Average capacity: *Dezimalzahl, durchschnittliche Kapazität der Gebäude(z.B. Schüler pro Schulhaus)*

Hierbei sind ganze Zahlen ohne Tausender-Trennzeichen und Dezimalzahlen mit Punkt getrennt zu schreiben.

Als nächstes werden die zu verarbeitenden Daten als *.csv-Datei eingefügt:
* in der ersten Spate steht das Alter
* die zweite Spalte enthät die Anzahl der Personen im jeweiligen Alter
* Spalten werden mit Semikolon getrennt
* Prognosen zu Geburten werden als "negatives Alter" eingetragen (Anzahl der Kinder, die in 5 Jaheren geboren werden haben das Alter "-5")
* analog zu Berufseinsteigern: Lehrkräfte in Ausbildung werden mit ihrem aktuellen Alter in die Liste eingefügt

## Ausgabe
* Programm starten

## Funktionsweise des Programmes

Unser Programm hat folgenden Aufbau:

* uml

Zunächst wird in der "Main"-Funktion in der Klasse "Programm" ein neues Objekt von "Variables" namens "var" erstellt.
Durch aufruf der "NameVariables"-Funktion in "var" wird die Datei "variables.txt" eingelesen und in dern Properties des Objektes gespeichert.

Anschließend wird ein neues Objekt von "Datacoordinator" erstellt. Hier mit dem Namen "schools", da es im ersten Beispiel um Schüler, Lehrer und Schulgebäude geht.
Der Coordinator gewährleistet eine thematische Sortierung der Daten und stellt einen zentralen Zugriff bereit.

Falls eine Datei mit Daten zur Alterstruktur der allgemeinen Bevölkeung hinterlegt wurde, wird nun die static-Funktion "DataToAgeGroup" aufgerufen, welche einzelne Objekte von "AgeGroup" erstellt in einer Liste sammelt und diese Liste zurückgibt. Die Liste wird im Coordinator gespeichter.
Bei erstellen der Obejekte von AgeGroup werden das Mindest- und Maximalalter aus der "variables.txt"-Datei berücksichtigt, um nicht unnötig viele Objekte zu erstellen, sowie die Spannweite der einzelnen Altersgruppen, um eine Benutzerdefinierte Genauigkeit der Berechnungen zu gewährleisten.

Wurden Variablen für eine Berufsbezeichnung und eine entsprechende csv-Datei hinterlegt, werden diese Daten nun der "Professions"-Liste in "schools" hinzugefügt.
Die Abfrage der Existenz dieser beiden Variablen dient einerseits der Flexibiltät des Programms - nicht jeder möchte alle Funktionen nutzen - andererseits ist die Berufsbezeichnung notwendig, um später auf die Daten zugreifen zu können.
Um die csv-Datei auszulesen wird wieder eine Liste mit entsprechenden Altersgruppen erstellt. Die Spanne der einzelnen Altersgruppen ist für hier die selbe wie für die allgemeine Bevölkerung um Vergleiche und Berechnungen zu vereinheitlichen.

Ähnlich funtioniert das einlesen von Gebäude-Daten:
Nur wenn eine Gebäude-Bezeichnung in der txt-Datei hinterlegt wurde, wird ein neues Objekt der Klasse "Infrastructure" erstellt.
Da hier nur sehr wenige Daten erfasst werden ,werden diese nicht aus einer csv-Datei, sondern direkt aus der txt eingelesen.
Das neu erstellte Objekt wird automatisch in der Liste für Infrastructure im Coordinator "schools" ergänzt.

* ausgabe

Für *.csv-Dateien haben wir uns entschieden, da die Struktur der einzelnen Datensätze nicht sehr komplex ist. xml-Datenbanken sind für diese geringe Menge an Daten nicht unbedingt notwendig und so war für eine erste Version des Programms die Übersichtlichkeit von csv-Dateien ausschlaggebend.

Im Repository liegen zwei csv-Dateien mit Daten zur allgemeinen Bevölkerung und zu Lehrkräften bei. 
Daten für Zukunftsprognosen fehlen hier, da kaum ausreichend konkrete Datensätze zu finden waren.
Unser Anspruch ist auch nicht, einen konkreten Datensatz zu verarbeiten und ein Ergebnis bereitzustellen, sondern ein Programm zu erstellen, das zur Verarbeitung verschiedener Datensätze geeignet ist.

## Vision
Aktuell ist nur die Bearbeitung eines Themas möglich.
Jedoch können ähnliche Aspekte , wie z.B. Altenpflege recht einfach ergänzt werden, die einzulesenden Datensätze haben die selber Struktur, wie die für Schulen.
Angepasst werden müssen also nur die Berechnungen.

Auch die Vorgaben für die Form der csv-Dateien ist sehr strikt. 
Um in diesem Bereich die Möglichkeiten zu erweitern müssten nur die Funktionen zu einlesen und speichern der Daten in Klassen verändert werde, ohne, dass das gesamte Programm überarbeitet werden muss.
Auch die zusätzliche Option, Daten aus xml-Dateien einzulesen ist durchaus denkbar, war für uns allerdings zeitlich nicht zu realisieren.

