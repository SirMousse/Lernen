using System;
using System.IO;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 12 - DATEIEN LESEN UND SCHREIBEN
             * =========================================
             *
             * Willkommen im Speicher-Kristall von DotNetia.
             *
             * Bisher waren alle Daten weg,
             * sobald das Programm beendet wurde.
             *
             * Mit Dateien können wir Daten speichern.
             *
             * Wichtig:
             *
             * using System.IO;
             */

            /*
             * =========================================
             * TEXT IN DATEI SCHREIBEN
             * =========================================
             */

            File.WriteAllText(
                "spielstand.txt",
                "Held Level 1"
            );

            Console.WriteLine("Datei wurde geschrieben.");

            /*
             * WriteAllText erstellt eine Datei
             * oder überschreibt sie komplett.
             */

            /*
             * =========================================
             * TEXT AUS DATEI LESEN
             * =========================================
             */

            string text =
                File.ReadAllText("spielstand.txt");

            Console.WriteLine("Dateiinhalt:");
            Console.WriteLine(text);

            /*
             * =========================================
             * TEXT AN DATEI ANHÄNGEN
             * =========================================
             */

            File.AppendAllText(
                "spielstand.txt",
                "\nGold: 100"
            );

            Console.WriteLine("Text wurde angehängt.");

            /*
             * =========================================
             * MEHRERE ZEILEN SCHREIBEN
             * =========================================
             */

            string[] zeilen =
            {
                "Name: Held",
                "Level: 5",
                "Gold: 250"
            };

            File.WriteAllLines(
                "charakter.txt",
                zeilen
            );

            /*
             * =========================================
             * MEHRERE ZEILEN LESEN
             * =========================================
             */

            string[] geleseneZeilen =
                File.ReadAllLines("charakter.txt");

            Console.WriteLine();
            Console.WriteLine("Charakterdaten:");

            foreach (string zeile in geleseneZeilen)
            {
                Console.WriteLine(zeile);
            }

            /*
             * =========================================
             * EXISTIERT EINE DATEI?
             * =========================================
             */

            if (File.Exists("charakter.txt"))
            {
                Console.WriteLine("Datei gefunden.");
            }
            else
            {
                Console.WriteLine("Datei fehlt.");
            }

            /*
             * =========================================
             * DATEIEN UND TRY/CATCH
             * =========================================
             */

            try
            {
                string inhalt =
                    File.ReadAllText("nichtDa.txt");

                Console.WriteLine(inhalt);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(
                    "Datei wurde nicht gefunden."
                );
            }

            /*
             * =========================================
             * MINI-PROJEKT
             * SPIELSTAND SPEICHERN
             * =========================================
             */

            Spieler spieler =
                new Spieler("Held", 3, 120, 75);

            SpeichereSpielstand(spieler);

            Spieler geladenerSpieler =
                LadeSpielstand();

            Console.WriteLine();
            Console.WriteLine("Geladener Spielstand:");
            geladenerSpieler.ZeigeDaten();

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Schreibe deinen Lieblingsspruch
             * in eine Datei namens:
             *
             * spruch.txt
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Lies spruch.txt wieder aus
             * und gib den Inhalt aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Schreibe mehrere Zeilen in:
             *
             * inventar.txt
             *
             * Beispiel:
             *
             * Schwert
             * Heiltrank
             * Schild
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Prüfe, ob inventar.txt existiert.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Baue try/catch ein,
             * wenn eine Datei gelesen wird.
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF
             * FILE-NOT-FOUND-GEIST
             * =========================================
             *
             * Problem:
             *
             * File.ReadAllText("save.txt");
             *
             * Wenn save.txt nicht existiert,
             * stürzt das Programm ab.
             *
             * Lösung:
             *
             * File.Exists()
             *
             * oder
             *
             * try/catch
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 12 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Speicher-Kristall");
            Console.WriteLine("+ Datei-Zauber");
        }

        static void SpeichereSpielstand(Spieler spieler)
        {
            string[] daten =
            {
                spieler.Name,
                spieler.Level.ToString(),
                spieler.Lebenspunkte.ToString(),
                spieler.Gold.ToString()
            };

            File.WriteAllLines(
                "savegame.txt",
                daten
            );
        }

        static Spieler LadeSpielstand()
        {
            string[] daten =
                File.ReadAllLines("savegame.txt");

            string name = daten[0];
            int level = Convert.ToInt32(daten[1]);
            int leben = Convert.ToInt32(daten[2]);
            int gold = Convert.ToInt32(daten[3]);

            return new Spieler(
                name,
                level,
                leben,
                gold
            );
        }
    }

    class Spieler
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int Lebenspunkte { get; set; }

        public int Gold { get; set; }

        public Spieler(
            string name,
            int level,
            int lebenspunkte,
            int gold)
        {
            Name = name;
            Level = level;
            Lebenspunkte = lebenspunkte;
            Gold = gold;
        }

        public void ZeigeDaten()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Leben: {Lebenspunkte}");
            Console.WriteLine($"Gold: {Gold}");
        }
    }
}