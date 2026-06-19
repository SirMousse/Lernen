using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 11 - GENERICS, COLLECTIONS UND LINQ
             * =========================================
             *
             * Willkommen im Archiv der Datenmagier.
             *
             * Bisher kennst du:
             *
             * - Arrays
             * - Listen
             *
             * Jetzt wird es mächtiger:
             *
             * - Generics
             * - Dictionary
             * - Queue
             * - Stack
             * - LINQ
             */

            /*
             * =========================================
             * GENERICS
             * =========================================
             *
             * Generics erkennst du an <T>.
             *
             * Beispiel:
             *
             * List<string>
             *
             * Bedeutet:
             *
             * Eine Liste, die nur string-Werte speichern darf.
             */

            List<string> inventar = new List<string>();

            inventar.Add("Schwert");
            inventar.Add("Heiltrank");
            inventar.Add("Mana-Trank");

            foreach (string item in inventar)
            {
                Console.WriteLine(item);
            }

            /*
             * =========================================
             * DICTIONARY
             * =========================================
             *
             * Ein Dictionary speichert Schlüssel-Wert-Paare.
             *
             * Nerd-Bild:
             *
             * Wie ein Lexikon:
             *
             * Schlüssel -> Wert
             *
             * Itemname -> Preis
             */

            Dictionary<string, int> shop =
                new Dictionary<string, int>();

            shop.Add("Schwert", 100);
            shop.Add("Schild", 80);
            shop.Add("Heiltrank", 25);

            Console.WriteLine();
            Console.WriteLine("=== Shop ===");

            foreach (KeyValuePair<string, int> eintrag in shop)
            {
                Console.WriteLine($"{eintrag.Key}: {eintrag.Value} Gold");
            }

            Console.WriteLine();
            Console.WriteLine($"Preis Schwert: {shop["Schwert"]} Gold");

            /*
             * Achtung:
             *
             * Wenn ein Key nicht existiert,
             * kann ein Fehler entstehen.
             *
             * Sicherer:
             */

            if (shop.ContainsKey("Bogen"))
            {
                Console.WriteLine(shop["Bogen"]);
            }
            else
            {
                Console.WriteLine("Bogen ist nicht im Shop.");
            }

            /*
             * =========================================
             * QUEUE
             * =========================================
             *
             * Eine Queue ist eine Warteschlange.
             *
             * First In, First Out.
             *
             * Wer zuerst reingeht,
             * kommt zuerst raus.
             */

            Queue<string> warteschlange =
                new Queue<string>();

            warteschlange.Enqueue("NPC 1");
            warteschlange.Enqueue("NPC 2");
            warteschlange.Enqueue("NPC 3");

            Console.WriteLine();
            Console.WriteLine("Nächster NPC:");

            Console.WriteLine(warteschlange.Dequeue());

            /*
             * Enqueue() = hinzufügen
             * Dequeue() = entfernen und zurückgeben
             * Peek()    = anschauen ohne entfernen
             */

            /*
             * =========================================
             * STACK
             * =========================================
             *
             * Ein Stack ist ein Stapel.
             *
             * Last In, First Out.
             *
             * Das letzte Element kommt zuerst raus.
             */

            Stack<string> zauberStapel =
                new Stack<string>();

            zauberStapel.Push("Feuerball");
            zauberStapel.Push("Eislanze");
            zauberStapel.Push("Blitzschlag");

            Console.WriteLine();
            Console.WriteLine("Oberster Zauber:");

            Console.WriteLine(zauberStapel.Pop());

            /*
             * Push() = oben drauflegen
             * Pop()  = oberstes Element entfernen
             * Peek() = anschauen ohne entfernen
             */

            /*
             * =========================================
             * LINQ
             * =========================================
             *
             * LINQ bedeutet:
             *
             * Language Integrated Query
             *
             * Damit kannst du Daten filtern,
             * sortieren und umwandeln.
             *
             * Wichtig:
             *
             * using System.Linq;
             */

            List<int> zahlen =
                new List<int>()
                {
                    5,
                    20,
                    3,
                    99,
                    42,
                    7
                };

            List<int> großeZahlen =
                zahlen
                    .Where(zahl => zahl >= 20)
                    .ToList();

            Console.WriteLine();
            Console.WriteLine("Zahlen >= 20:");

            foreach (int zahl in großeZahlen)
            {
                Console.WriteLine(zahl);
            }

            /*
             * =========================================
             * LAMBDA =>
             * =========================================
             *
             * zahl => zahl >= 20
             *
             * Bedeutet:
             *
             * Nimm jede zahl.
             * Behalte sie nur,
             * wenn sie >= 20 ist.
             */

            /*
             * =========================================
             * ORDERBY
             * =========================================
             */

            List<int> sortiert =
                zahlen
                    .OrderBy(zahl => zahl)
                    .ToList();

            Console.WriteLine();
            Console.WriteLine("Sortiert:");

            foreach (int zahl in sortiert)
            {
                Console.WriteLine(zahl);
            }

            /*
             * =========================================
             * SELECT
             * =========================================
             *
             * Select wandelt Werte um.
             */

            List<string> itemTexte =
                inventar
                    .Select(item => $"Item: {item}")
                    .ToList();

            Console.WriteLine();
            Console.WriteLine("Item-Texte:");

            foreach (string text in itemTexte)
            {
                Console.WriteLine(text);
            }

            /*
             * =========================================
             * LINQ MIT OBJEKTEN
             * =========================================
             */

            List<Quest> quests =
                new List<Quest>()
                {
                    new Quest("Rette das Dorf", 100, true),
                    new Quest("Besiege den Drachen", 500, false),
                    new Quest("Sammle Kräuter", 50, true),
                    new Quest("Finde das Artefakt", 300, false)
                };

            List<Quest> aktiveQuests =
                quests
                    .Where(quest => quest.IstAktiv)
                    .ToList();

            Console.WriteLine();
            Console.WriteLine("Aktive Quests:");

            foreach (Quest quest in aktiveQuests)
            {
                Console.WriteLine(quest.Name);
            }

            Quest besteQuest =
                quests
                    .OrderByDescending(quest => quest.Erfahrung)
                    .First();

            Console.WriteLine();
            Console.WriteLine($"Beste Quest: {besteQuest.Name}");

            /*
             * =========================================
             * FIRST, FIRSTORDEFAULT
             * =========================================
             *
             * First() gibt das erste passende Element zurück.
             *
             * Achtung:
             * Wenn nichts gefunden wird, gibt es einen Fehler.
             *
             * Sicherer:
             *
             * FirstOrDefault()
             */

            Quest drachenQuest =
                quests
                    .FirstOrDefault(
                        quest => quest.Name == "Besiege den Drachen"
                    );

            if (drachenQuest != null)
            {
                Console.WriteLine("Drachenquest gefunden.");
            }

            /*
             * =========================================
             * MINI-PROJEKT
             * QUEST-VERWALTUNG
             * =========================================
             */

            Console.WriteLine();
            Console.WriteLine("=== Quest-Verwaltung ===");

            foreach (Quest quest in quests)
            {
                Console.WriteLine(
                    $"{quest.Name} | EP: {quest.Erfahrung} | Aktiv: {quest.IstAktiv}"
                );
            }

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle ein Dictionary:
             *
             * string -> int
             *
             * Speichere:
             *
             * Apfel = 5
             * Schwert = 100
             * Schild = 80
             *
             * Gib alles aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle eine Queue mit 3 NPCs.
             *
             * Entferne den ersten NPC mit Dequeue().
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle einen Stack mit 3 Zaubern.
             *
             * Entferne den obersten Zauber mit Pop().
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle eine Liste mit Zahlen.
             *
             * Nutze LINQ:
             *
             * Filtere alle Zahlen größer als 10.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Erstelle eine Liste von Quests.
             *
             * Filtere alle aktiven Quests.
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF
             * SPAGHETTI-CODE-KRAKEN
             * =========================================
             *
             * Problem:
             *
             * Viele Daten unorganisiert speichern.
             *
             * Lösung:
             *
             * Collections + LINQ.
             *
             * Damit kannst du:
             *
             * - Daten sauber speichern
             * - Daten durchsuchen
             * - Daten filtern
             * - Daten sortieren
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 11 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Dictionary-Schlüssel");
            Console.WriteLine("+ LINQ-Zauberbuch");
            Console.WriteLine("+ Krakenjäger-Titel");
        }
    }

    class Quest
    {
        public string Name { get; set; }

        public int Erfahrung { get; set; }

        public bool IstAktiv { get; set; }

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
}