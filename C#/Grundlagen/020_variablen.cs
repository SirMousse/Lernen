using System;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 2 - VARIABLEN UND DATENTYPEN
             * =========================================
             *
             * Variablen sind Speicherboxen.
             *
             * Stell dir vor:
             *
             * Eine Variable ist wie eine Truhe in einem RPG.
             * Du gibst ihr einen Namen und legst etwas hinein.
             *
             * Beispiel:
             */

            string spielerName = "Held";

            Console.WriteLine(spielerName);

            /*
             * =========================================
             * AUFBAU EINER VARIABLE
             * =========================================
             *
             * string spielerName = "Held";
             *
             * string       -> Datentyp
             * spielerName  -> Name der Variable
             * =            -> weist einen Wert zu
             * "Held"       -> gespeicherter Wert
             * ;            -> Ende der Anweisung
             */

            /*
             * =========================================
             * WICHTIGE DATENTYPEN
             * =========================================
             *
             * string  -> Text
             * int     -> ganze Zahlen
             * double  -> Kommazahlen
             * bool    -> true oder false
             * char    -> einzelnes Zeichen
             */

            string klasse = "Code-Magier";
            int level = 1;
            double leben = 99.5;
            bool hatLegendäreWaffe = true;
            char rang = 'A';

            Console.WriteLine(klasse);
            Console.WriteLine(level);
            Console.WriteLine(leben);
            Console.WriteLine(hatLegendäreWaffe);
            Console.WriteLine(rang);

            /*
             * =========================================
             * STRING - TEXT
             * =========================================
             *
             * Strings stehen immer in doppelten Anführungszeichen.
             */

            string haustier = "Katze";

            Console.WriteLine("Haustier:");
            Console.WriteLine(haustier);

            /*
             * =========================================
             * INT - GANZE ZAHLEN
             * =========================================
             *
             * int speichert ganze Zahlen.
             *
             * Beispiele:
             *
             * 1
             * 42
             * -7
             * 9000
             */

            int gold = 150;

            Console.WriteLine("Gold:");
            Console.WriteLine(gold);

            /*
             * =========================================
             * DOUBLE - KOMMAZAHLEN
             * =========================================
             *
             * double speichert Kommazahlen.
             *
             * Wichtig:
             * In C# benutzt man einen Punkt statt eines Kommas.
             *
             * Richtig:
             * 3.14
             *
             * Falsch:
             * 3,14
             */

            double mana = 75.5;

            Console.WriteLine("Mana:");
            Console.WriteLine(mana);

            /*
             * =========================================
             * BOOL - WAHR ODER FALSCH
             * =========================================
             *
             * bool kennt nur zwei Zustände:
             *
             * true
             * false
             */

            bool questAktiv = true;

            Console.WriteLine("Quest aktiv:");
            Console.WriteLine(questAktiv);

            /*
             * =========================================
             * CHAR - EIN ZEICHEN
             * =========================================
             *
             * char speichert genau ein Zeichen.
             *
             * Wichtig:
             * char verwendet einfache Anführungszeichen.
             */

            char symbol = '#';

            Console.WriteLine("Symbol:");
            Console.WriteLine(symbol);

            /*
             * =========================================
             * VARIABLEN ÄNDERN
             * =========================================
             */

            int punkte = 10;

            Console.WriteLine("Punkte vorher:");
            Console.WriteLine(punkte);

            punkte = 20;

            Console.WriteLine("Punkte nach dem Level-Up:");
            Console.WriteLine(punkte);

            /*
             * WICHTIG:
             *
             * Beim Ändern einer Variable schreibt man
             * den Datentyp NICHT erneut hin.
             *
             * Richtig:
             *
             * punkte = 20;
             *
             * Falsch:
             *
             * int punkte = 20;
             */

            /*
             * =========================================
             * TEXT UND VARIABLEN VERBINDEN
             * =========================================
             */

            string name = "Spieler";
            int spielerLevel = 5;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Level: " + spielerLevel);

            /*
             * Moderne Variante:
             *
             * String Interpolation
             */

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Level: {spielerLevel}");

            /*
             * =========================================
             * RECHNEN MIT VARIABLEN
             * =========================================
             */

            int angriff = 10;
            int bonus = 5;
            int schaden = angriff + bonus;

            Console.WriteLine($"Schaden: {schaden}");

            /*
             * Rechenoperatoren:
             *
             * + Addition
             * - Subtraktion
             * * Multiplikation
             * / Division
             * % Modulo (Rest)
             */

            int a = 10;
            int b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            /*
             * Achtung:
             *
             * int / int ergibt wieder int.
             *
             * 10 / 3 = 3
             */

            double genau = 10.0 / 3.0;

            Console.WriteLine(genau);

            /*
             * =========================================
             * NAMENSREGELN
             * =========================================
             *
             * Erlaubt:
             *
             * spielerName
             * level2
             * aktuelleLeben
             *
             * Nicht erlaubt:
             *
             * 2level
             * spieler-name
             * class
             *
             * "class" ist ein reserviertes Wort.
             */

            /*
             * =========================================
             * BEST PRACTICE: CAMELCASE
             * =========================================
             *
             * Variablen beginnen klein.
             *
             * Beispiele:
             *
             * spielerName
             * aktuellePunkte
             * maximaleLeben
             */

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle eine Variable für einen Namen
             * und gib ihn aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle:
             *
             * name
             * klasse
             * level
             *
             * Gib alles aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle:
             *
             * schwertSchaden = 12
             * magieSchaden = 8
             *
             * Berechne den Gesamtschaden.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle:
             *
             * double leben = 87.5;
             * bool bossBesiegt = false;
             * char rang = 'S';
             *
             * Gib alle Werte aus.
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF
             * =========================================
             *
             * Finde alle Fehler:
             *
             * string name = Spieler;
             * int 2level = 5;
             * double mana = 44,5;
             * bool quest = "true";
             *
             * Richtige Lösung:
             *
             * string name = "Spieler";
             * int level2 = 5;
             * double mana = 44.5;
             * bool quest = true;
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 2 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Datentyp-Amulett");
            Console.WriteLine("+ Variablen-Truhe");
        }
    }
}