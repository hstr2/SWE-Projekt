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
* in der ersten Spalte steht das Alter
* die zweite Spalte enthät die Anzahl der Personen im jeweiligen Alter
* Spalten werden mit Semikolon getrennt
* Prognosen zu Geburten werden als "negatives Alter" eingetragen (Anzahl der Kinder, die in 5 Jaheren geboren werden haben das Alter "-5")
* analog zu Berufseinsteigern: Lehrkräfte in Ausbildung werden mit ihrem aktuellen Alter in die Liste eingefügt

## Ausgabe
Um das Programm zum Laufen zu bringen nutzen Sie bitte Visual Studio Code.
Sie werden, wenn Ihre Datei keine Fehler aufweist, eine XML-Datei namens "results.XML" erhalten. Um nun die Ausgabe zu erhalten, benötigen Sie Jupyter Notebooks mit C#.
Sie installieren also folgende Dinge:
* Jupyter Notebooks
* .NET 3.1 SDK
* C# für Jupyter Notebooks

Sie können diese mithilfe des folgenden Links installieren (https://devblogs.microsoft.com/dotnet/net-interactive-is-here-net-notebooks-preview-2/).

Auf Jupyter Notebooks angekommen müssen Sie die Datei "Table.ipynb" hochladen sowie die "results.XML"-Datei.
Nun klicken Sie auf die Datei "Table.ipynb" und es öffnet sich das Notebook.

Nun können Sie den Code ausführen lassen und erhalten eine Tabelle mit den Prognosen.

## Funktionsweise des Programmes

Unser Programm hat folgenden Aufbau:

![UML-Diagramm](
https://www.plantuml.com/plantuml/png/ZLDDQzmm4BthL_YOXUImLrEQZorT2aqQagMbb1ucrcGZAckCFhODfV-zevLahOqBlHXvFjwRzpIwSXwi3xqMejFWN7DlQM-X5x_5nY9ulDxZrb8Ot9ao_hmfdrNBZLvrpM3LWSkQZyfvyO0Wtu67C-UjCljLs-Igc7sJWj--lnMnPaS5EbTNyCfGUdC73_UCpYaoOyzohxW5bMkOS8Gwa9BYJv4QCJT4LYe3dYnB7iMsYRNobSW7yso1SKFdWyKItP47VOyqQ6mZlvX1dwt41dGND7Xy37trTDNEPYef7kOh1RD7vnFY9ot7yrtedz2cysXYrRwZnwDmHX_2asRTT41hbSJiLgMh0fdm3dfiSyNCYSiayPHuuIuY-rAS4VwTEF_FcRVeZpDm1NTK2TCROHcxrm7RqfKclWbAI_vrsJE6XZrkO81E-TUsaSISEBlSwLgcabNb_GnM0OSSKpu0tzJrjbWMEMwLOG_J4NwLutkbyGOFSJsoqvVY2zaVjJhzrexgsdhiY2WnNYD5O8rCXQyNXQ_RfAgAAbkQ5cAW8VySH_48tGlQfC_v8D7u_DEz46atgJA84kL9-ZGoM9IgYyZyDBfC6jz97MKNpUKXebV7ytJDEjAXDwxigwMVhkp5xF4rT75HtzLISdhlIoMd3wKUfyZLkvH80iGL6Xbw_HS0)

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

Das Programm hinterlegt einen XML-Datei, die als Datensatz dient für die .ipynb-Datei, die diese Daten dann tabellarich darstellt.

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

