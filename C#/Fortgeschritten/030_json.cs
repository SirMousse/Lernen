using System;
using System.Collections.Generic;
using System.Text.Json;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 13 - JSON SPEICHERN UND LADEN
             * =========================================
             *
             * JSON ist ein sehr häufiges Datenformat.
             *
             * Es wird benutzt für:
             *
             * - Spielstände
             * - APIs
             * - Einstellungen
             * - Datenübertragung
             *
             * JSON sieht ungefähr so aus:
             *
             * {
             *   "Name": "Held",
             *   "Level": 5
             * }
             *
             * Wichtig:
             *
             * using System.Text.Json;
             */

            Spieler spieler = new Spieler(
                "Held",
                5,
                120,
                250
            );

            spieler.Inventar.Add("Schwert");
            spieler.Inventar.Add("Heiltrank");
            spieler.Inventar.Add("Magischer Ring");

            /*
             * =========================================
             * OBJEKT IN JSON UMWANDELN
             * =========================================
             */

            string json = JsonSerializer.Serialize(
                spieler,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            Console.WriteLine("JSON-Ausgabe:");
            Console.WriteLine(json);

            /*
             * =========================================
             * JSON IN DATEI SPEICHERN
             * =========================================
             */

            File.WriteAllText(
                "spieler.json",
                json
            );

            Console.WriteLine("Spieler wurde gespeichert.");

            /*
             * =========================================
             * JSON AUS DATEI LADEN
             * =========================================
             */

            string geladenerJson =
                File.ReadAllText("spieler.json");

            Spieler geladenerSpieler =
                JsonSerializer.Deserialize<Spieler>(
                    geladenerJson
                );

            Console.WriteLine();
            Console.WriteLine("Geladener Spieler:");

            geladenerSpieler.ZeigeDaten();

            /*
             * =========================================
             * LISTE ALS JSON SPEICHERN
             * =========================================
             */

            List<Quest> quests =
                new List<Quest>()
                {
                    new Quest("Rette das Dorf", 100, true),
                    new Quest("Besiege den Drachen", 500, false),
                    new Quest("Sammle Kräuter", 50, true)
                };

            string questJson =
                JsonSerializer.Serialize(
                    quests,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    }
                );

            File.WriteAllText(
                "quests.json",
                questJson
            );

            Console.WriteLine();
            Console.WriteLine("Quests gespeichert.");

            /*
             * =========================================
             * LISTE AUS JSON LADEN
             * =========================================
             */

            string geladeneQuestDaten =
                File.ReadAllText("quests.json");

            List<Quest> geladeneQuests =
                JsonSerializer.Deserialize<List<Quest>>(
                    geladeneQuestDaten
                );

            Console.WriteLine();
            Console.WriteLine("Geladene Quests:");

            foreach (Quest quest in geladeneQuests)
            {
                Console.WriteLine(
                    $"{quest.Name} | EP: {quest.Erfahrung} | Aktiv: {quest.IstAktiv}"
                );
            }

            /*
             * =========================================
             * TRY/CATCH BEIM LADEN
             * =========================================
             */

            try
            {
                string daten =
                    File.ReadAllText("spieler.json");

                Spieler sicherGeladen =
                    JsonSerializer.Deserialize<Spieler>(
                        daten
                    );

                Console.WriteLine();
                Console.WriteLine("Sicher geladen:");
                sicherGeladen.ZeigeDaten();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(
                    "Speicherdatei nicht gefunden."
                );
            }
            catch (JsonException)
            {
                Console.WriteLine(
                    "JSON-Datei ist beschädigt."
                );
            }

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle ein Objekt:
             *
             * Waffe
             *
             * Eigenschaften:
             *
             * Name
             * Schaden
             *
             * Speichere es als JSON.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Lade die Waffe wieder aus der JSON-Datei.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle eine Liste mit Items.
             *
             * Speichere sie als JSON.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle eine Klasse:
             *
             * Einstellung
             *
             * Eigenschaften:
             *
             * Lautstärke
             * Vollbild
             * Schwierigkeit
             *
             * Speichere sie als JSON.
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF
             * JSON-GOBLIN
             * =========================================
             *
             * Problem:
             *
             * JSON-Datei fehlt oder ist kaputt.
             *
             * Lösung:
             *
             * try/catch
             *
             * File.Exists()
             *
             * JsonException abfangen
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 13 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ JSON-Schriftrolle");
            Console.WriteLine("+ Savegame-Meisterschaft");
        }
    }

    class Spieler
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int Lebenspunkte { get; set; }

        public int Gold { get; set; }

        public List<string> Inventar { get; set; }

        public Spieler()
        {
            Inventar = new List<string>();
        }

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
            Inventar = new List<string>();
        }

        public void ZeigeDaten()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Leben: {Lebenspunkte}");
            Console.WriteLine($"Gold: {Gold}");

            Console.WriteLine("Inventar:");

            foreach (string item in Inventar)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }

    class Quest
    {
        public string Name { get; set; }

        public int Erfahrung { get; set; }

        public bool IstAktiv { get; set; }

        public Quest()
        {
        }

        public Quest(
            string name,
            int erfahrung,
            bool istAktiv)
        {
            Name = name;
            Erfahrung = erfahrung;
            IstAktiv = istAktiv;
        }
    }

    class Waffe
    {
        public string Name { get; set; }

        public int Schaden { get; set; }

        public Waffe()
        {
        }

        public Waffe(
            string name,
            int schaden)
        {
            Name = name;
            Schaden = schaden;
        }
    }

    class Einstellung
    {
        public int Lautstärke { get; set; }

        public bool Vollbild { get; set; }

        public string Schwierigkeit { get; set; }
    }
}