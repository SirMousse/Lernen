using System;
using System.Collections.Generic;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 14 - ENUMS
             * =========================================
             *
             * Enums sind Aufzählungen.
             *
             * Sie helfen dir, feste Auswahlmöglichkeiten
             * sauber zu speichern.
             *
             * Beispiel:
             *
             * Schwierigkeit:
             *
             * Einfach
             * Normal
             * Schwer
             *
             * Statt Text zu verwenden, nutzt man enum.
             */

            Schwierigkeit aktuelleSchwierigkeit =
                Schwierigkeit.Normal;

            Console.WriteLine(
                $"Schwierigkeit: {aktuelleSchwierigkeit}"
            );

            /*
             * =========================================
             * WARUM ENUMS?
             * =========================================
             *
             * Ohne enum:
             *
             * string schwierigkeit = "schwer";
             *
             * Problem:
             *
             * "Schwer"
             * "schwer"
             * "scher"
             * "SCHWER"
             *
             * Alles wäre möglich.
             *
             * Mit enum gibt es nur erlaubte Werte.
             */

            /*
             * =========================================
             * ENUM MIT IF
             * =========================================
             */

            if (aktuelleSchwierigkeit == Schwierigkeit.Einfach)
            {
                Console.WriteLine("Gegner sind schwach.");
            }
            else if (aktuelleSchwierigkeit == Schwierigkeit.Normal)
            {
                Console.WriteLine("Normale Herausforderung.");
            }
            else if (aktuelleSchwierigkeit == Schwierigkeit.Schwer)
            {
                Console.WriteLine("Gegner sind brutal stark.");
            }

            /*
             * =========================================
             * ENUM MIT SWITCH
             * =========================================
             */

            CharakterKlasse klasse =
                CharakterKlasse.Magier;

            switch (klasse)
            {
                case CharakterKlasse.Krieger:
                    Console.WriteLine("Du trägst eine schwere Rüstung.");
                    break;

                case CharakterKlasse.Magier:
                    Console.WriteLine("Du wirkst mächtige Zauber.");
                    break;

                case CharakterKlasse.Bogenschütze:
                    Console.WriteLine("Du kämpfst aus der Ferne.");
                    break;

                case CharakterKlasse.Heiler:
                    Console.WriteLine("Du rettest deine Gruppe.");
                    break;
            }

            /*
             * =========================================
             * ENUM IN EINER KLASSE
             * =========================================
             */

            Held held = new Held(
                "Arthos",
                CharakterKlasse.Krieger,
                Schwierigkeit.Schwer
            );

            held.ZeigeDaten();

            /*
             * =========================================
             * ENUM ALS ZAHL
             * =========================================
             *
             * Intern haben enum-Werte Zahlen.
             *
             * Standard:
             *
             * Erster Wert = 0
             * Zweiter Wert = 1
             * Dritter Wert = 2
             */

            int schwierigkeitsZahl =
                (int)Schwierigkeit.Schwer;

            Console.WriteLine(
                $"Schwer als Zahl: {schwierigkeitsZahl}"
            );

            /*
             * =========================================
             * ZAHL ZU ENUM UMWANDELN
             * =========================================
             */

            Schwierigkeit ausZahl =
                (Schwierigkeit)1;

            Console.WriteLine(
                $"Zahl 1 als Schwierigkeit: {ausZahl}"
            );

            /*
             * =========================================
             * ENUM AUS TEXT LESEN
             * =========================================
             */

            string eingabe = "Magier";

            CharakterKlasse gewählteKlasse =
                Enum.Parse<CharakterKlasse>(eingabe);

            Console.WriteLine(
                $"Gewählte Klasse: {gewählteKlasse}"
            );

            /*
             * =========================================
             * SICHERER MIT TRYPARSE
             * =========================================
             */

            Console.WriteLine();
            Console.WriteLine("Wähle eine Klasse:");
            Console.WriteLine("Krieger");
            Console.WriteLine("Magier");
            Console.WriteLine("Bogenschütze");
            Console.WriteLine("Heiler");

            string klassenEingabe =
                Console.ReadLine();

            bool erfolgreich =
                Enum.TryParse(
                    klassenEingabe,
                    true,
                    out CharakterKlasse spielerKlasse
                );

            if (erfolgreich)
            {
                Console.WriteLine(
                    $"Du hast gewählt: {spielerKlasse}"
                );
            }
            else
            {
                Console.WriteLine(
                    "Diese Klasse existiert nicht."
                );
            }

            /*
             * true bedeutet:
             *
             * Groß- und Kleinschreibung wird ignoriert.
             */

            /*
             * =========================================
             * MINI-PROJEKT
             * CHARAKTERERSTELLUNG MIT ENUM
             * =========================================
             */

            Console.WriteLine();
            Console.WriteLine("=== Charaktererstellung ===");

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Klasse wählen:");
            Console.WriteLine("Krieger");
            Console.WriteLine("Magier");
            Console.WriteLine("Bogenschütze");
            Console.WriteLine("Heiler");

            string klasseText = Console.ReadLine();

            bool klasseOk =
                Enum.TryParse(
                    klasseText,
                    true,
                    out CharakterKlasse neueKlasse
                );

            if (!klasseOk)
            {
                neueKlasse = CharakterKlasse.Krieger;

                Console.WriteLine(
                    "Ungültige Klasse. Standard: Krieger"
                );
            }

            Held neuerHeld =
                new Held(
                    name,
                    neueKlasse,
                    Schwierigkeit.Normal
                );

            neuerHeld.ZeigeDaten();

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle ein enum:
             *
             * Wochentag
             *
             * Werte:
             *
             * Montag
             * Dienstag
             * Mittwoch
             * Donnerstag
             * Freitag
             * Samstag
             * Sonntag
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle ein enum:
             *
             * ItemSeltenheit
             *
             * Werte:
             *
             * Gewöhnlich
             * Selten
             * Episch
             * Legendär
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle eine Klasse Item.
             *
             * Eigenschaften:
             *
             * Name
             * Seltenheit
             *
             * Seltenheit soll dein enum ItemSeltenheit sein.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Frage den Benutzer nach einer Schwierigkeit.
             *
             * Nutze Enum.TryParse.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Nutze switch mit einem enum.
             *
             * Je nach CharakterKlasse soll eine andere
             * Startwaffe ausgegeben werden.
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF
             * STRING-TYPO-GOBLIN
             * =========================================
             *
             * Problem:
             *
             * string status = "Aktiv";
             *
             * Später schreibt jemand:
             *
             * "aktiv"
             * "Akttiv"
             * "AKTIV"
             *
             * Ergebnis:
             *
             * Fehlerhafte Vergleiche.
             *
             * Lösung:
             *
             * enum verwenden.
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 14 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Enum-Rune");
            Console.WriteLine("+ Schutz gegen Tippfehler-Goblins");
        }
    }

    enum Schwierigkeit
    {
        Einfach,
        Normal,
        Schwer
    }

    enum CharakterKlasse
    {
        Krieger,
        Magier,
        Bogenschütze,
        Heiler
    }

    class Held
    {
        public string Name { get; set; }

        public CharakterKlasse Klasse { get; set; }

        public Schwierigkeit Schwierigkeit { get; set; }

        public Held(
            string name,
            CharakterKlasse klasse,
            Schwierigkeit schwierigkeit)
        {
            Name = name;
            Klasse = klasse;
            Schwierigkeit = schwierigkeit;
        }

        public void ZeigeDaten()
        {
            Console.WriteLine();
            Console.WriteLine("=== Held ===");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Klasse: {Klasse}");
            Console.WriteLine($"Schwierigkeit: {Schwierigkeit}");
        }
    }
}