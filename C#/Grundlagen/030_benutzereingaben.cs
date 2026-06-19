using System;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 3 - BENUTZEREINGABEN
             * =========================================
             *
             * Bisher hat dein Programm nur gesprochen.
             * Jetzt lernt es zuzuhören.
             *
             * Dafür benutzen wir:
             *
             * Console.ReadLine();
             *
             * Nerd-Bild:
             * Console.WriteLine() = NPC spricht
             * Console.ReadLine()  = Spieler antwortet
             */

            Console.WriteLine("Wie heißt dein Held?");
            string heldenName = Console.ReadLine();

            Console.WriteLine($"Willkommen, {heldenName}!");

            /*
             * =========================================
             * WICHTIG
             * =========================================
             *
             * Console.ReadLine() gibt IMMER einen string zurück.
             *
             * Auch wenn du eine Zahl eingibst, ist sie zuerst Text.
             */

            Console.WriteLine("Gib dein Level ein:");
            string levelAlsText = Console.ReadLine();

            Console.WriteLine($"Dein Level als Text: {levelAlsText}");

            /*
             * =========================================
             * STRING IN INT UMWANDELN
             * =========================================
             *
             * Wenn du mit einer eingegebenen Zahl rechnen willst,
             * musst du sie umwandeln.
             *
             * Dafür gibt es:
             *
             * Convert.ToInt32()
             */

            Console.WriteLine("Gib deine Lebenspunkte ein:");
            string lebenText = Console.ReadLine();

            int leben = Convert.ToInt32(lebenText);

            Console.WriteLine($"Deine Lebenspunkte: {leben}");

            /*
             * Kürzer geht es so:
             */

            Console.WriteLine("Gib deine Angriffskraft ein:");
            int angriff = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Angriffskraft: {angriff}");

            /*
             * =========================================
             * RECHNEN MIT EINGABEN
             * =========================================
             */

            Console.WriteLine("Gib deinen Grundschaden ein:");
            int grundSchaden = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib deinen Bonus-Schaden ein:");
            int bonusSchaden = Convert.ToInt32(Console.ReadLine());

            int gesamtSchaden = grundSchaden + bonusSchaden;

            Console.WriteLine($"Gesamtschaden: {gesamtSchaden}");

            /*
             * =========================================
             * DOUBLE EINGEBEN
             * =========================================
             *
             * Für Kommazahlen nutzt man:
             *
             * Convert.ToDouble()
             *
             * Achtung:
             * Je nach Systemeinstellung kann die Eingabe mit Komma
             * oder Punkt unterschiedlich funktionieren.
             *
             * In Code schreibt man Kommazahlen mit Punkt:
             *
             * double mana = 12.5;
             */

            Console.WriteLine("Gib deine Mana ein:");
            double mana = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Mana: {mana}");

            /*
             * =========================================
             * BOOL EINGEBEN
             * =========================================
             *
             * Für true oder false nutzt man:
             *
             * Convert.ToBoolean()
             *
             * Eingabe muss sein:
             *
             * true
             * false
             */

            Console.WriteLine("Ist die Quest aktiv? true oder false:");
            bool questAktiv = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"Quest aktiv: {questAktiv}");

            /*
             * =========================================
             * HÄUFIGE FEHLER
             * =========================================
             *
             * Fehler 1:
             *
             * int zahl = Console.ReadLine();
             *
             * Warum falsch?
             * Console.ReadLine() liefert string, nicht int.
             *
             * Richtig:
             *
             * int zahl = Convert.ToInt32(Console.ReadLine());
             *
             * -----------------------------------------
             *
             * Fehler 2:
             *
             * Eingabe: hallo
             * Erwartet: int
             *
             * Ergebnis:
             * Das Programm stürzt ab.
             *
             * Warum?
             * "hallo" kann nicht in eine Zahl umgewandelt werden.
             *
             * Später lernen wir TryParse.
             */

            /*
             * =========================================
             * MINI-PROJEKT: CHARAKTERBOGEN
             * =========================================
             */

            Console.WriteLine("=== Charakterbogen ===");

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Klasse:");
            string klasse = Console.ReadLine();

            Console.WriteLine("Level:");
            int level = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lebenspunkte:");
            int lebensPunkte = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mana:");
            double manaPunkte = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hat legendäre Waffe? true oder false:");
            bool hatLegendäreWaffe = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=== Dein Charakter ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Klasse: {klasse}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Lebenspunkte: {lebensPunkte}");
            Console.WriteLine($"Mana: {manaPunkte}");
            Console.WriteLine($"Legendäre Waffe: {hatLegendäreWaffe}");

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Frage den Benutzer nach seinem Lieblingsspiel
             * und gib danach aus:
             *
             * Dein Lieblingsspiel ist: ...
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Frage nach zwei Zahlen.
             * Addiere sie.
             * Gib das Ergebnis aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Frage nach:
             *
             * Name des Zaubers
             * Mana-Kosten
             * Schaden
             *
             * Gib danach einen Zauberbericht aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle einen kleinen Shop:
             *
             * Frage nach:
             *
             * Gold des Spielers
             * Preis des Items
             *
             * Berechne:
             *
             * Restgold = Gold - Preis
             *
             * Gib Restgold aus.
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF: DER READLINE-TROLL
             * =========================================
             *
             * Finde alle Fehler:
             *
             * Console.WriteLine("Alter:");
             * int alter = Console.ReadLine();
             *
             * Console.WriteLine("Preis:");
             * double preis = Console.ReadLine();
             *
             * Fehler:
             *
             * Console.ReadLine() liefert string.
             * Für Zahlen muss umgewandelt werden.
             *
             * Richtige Lösung:
             *
             * Console.WriteLine("Alter:");
             * int alter = Convert.ToInt32(Console.ReadLine());
             *
             * Console.WriteLine("Preis:");
             * double preis = Convert.ToDouble(Console.ReadLine());
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 3 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Eingabe-Kristall");
            Console.WriteLine("+ ReadLine-Zauber");
        }
    }
}