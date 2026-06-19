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
             * KAPITEL 7 - ARRAYS UND LISTEN
             * =========================================
             *
             * Willkommen im Inventar-Lager von DotNetia.
             *
             * Bisher konnten wir nur einzelne Werte speichern:
             *
             * int level = 10;
             * string name = "Held";
             *
             * Aber was ist, wenn wir:
             *
             * - 100 Gegner
             * - 50 Items
             * - 20 Zauber
             * - 1000 Spielernamen
             *
             * speichern möchten?
             *
             * Dafür gibt es:
             *
             * ARRAYS
             * LISTEN
             */

            /*
             * =========================================
             * ARRAYS
             * =========================================
             *
             * Ein Array speichert mehrere Werte
             * desselben Datentyps.
             */

            string[] inventar =
            {
                "Holzschwert",
                "Heiltrank",
                "Schild"
            };

            Console.WriteLine(inventar[0]);
            Console.WriteLine(inventar[1]);
            Console.WriteLine(inventar[2]);

            /*
             * Index:
             *
             * 0 = Holzschwert
             * 1 = Heiltrank
             * 2 = Schild
             *
             * WICHTIG:
             *
             * Arrays beginnen bei 0.
             * Nicht bei 1.
             */

            /*
             * =========================================
             * ARRAY-LÄNGE
             * =========================================
             */

            Console.WriteLine($"Anzahl Items: {inventar.Length}");

            /*
             * Length liefert die Anzahl der Elemente.
             */

            /*
             * =========================================
             * ARRAY DURCHLAUFEN
             * =========================================
             */

            Console.WriteLine();
            Console.WriteLine("Inventar:");

            for (int i = 0; i < inventar.Length; i++)
            {
                Console.WriteLine(inventar[i]);
            }

            /*
             * Erklärung:
             *
             * inventar.Length = 3
             *
             * i startet bei 0
             * i läuft bis kleiner als 3
             *
             * Dadurch werden alle Elemente ausgegeben.
             */

            /*
             * =========================================
             * FOREACH
             * =========================================
             *
             * Einfachere Variante zum Durchlaufen.
             */

            Console.WriteLine();
            Console.WriteLine("Inventar mit foreach:");

            foreach (string item in inventar)
            {
                Console.WriteLine(item);
            }

            /*
             * item enthält automatisch
             * das aktuelle Element.
             */

            /*
             * =========================================
             * ARRAY WERTE ÄNDERN
             * =========================================
             */

            inventar[0] = "Legendäres Schwert";

            Console.WriteLine();
            Console.WriteLine(inventar[0]);

            /*
             * =========================================
             * ARRAYS MIT ZAHLEN
             * =========================================
             */

            int[] schaden =
            {
                10,
                20,
                35,
                50
            };

            Console.WriteLine();

            foreach (int wert in schaden)
            {
                Console.WriteLine(wert);
            }

            /*
             * =========================================
             * LISTEN
             * =========================================
             *
             * Problem von Arrays:
             *
             * Größe ist fest.
             *
             * Listen können wachsen und schrumpfen.
             */

            List<string> loot = new List<string>();

            loot.Add("Heiltrank");
            loot.Add("Gold");
            loot.Add("Magischer Ring");

            Console.WriteLine();
            Console.WriteLine("Lootliste:");

            foreach (string item in loot)
            {
                Console.WriteLine(item);
            }

            /*
             * =========================================
             * ELEMENTE ENTFERNEN
             * =========================================
             */

            loot.Remove("Gold");

            Console.WriteLine();
            Console.WriteLine("Nach dem Entfernen:");

            foreach (string item in loot)
            {
                Console.WriteLine(item);
            }

            /*
             * =========================================
             * ENTHÄLT DIE LISTE EIN ITEM?
             * =========================================
             */

            bool hatRing =
                loot.Contains("Magischer Ring");

            Console.WriteLine();
            Console.WriteLine($"Ring vorhanden: {hatRing}");

            /*
             * =========================================
             * ANZAHL DER ELEMENTE
             * =========================================
             */

            Console.WriteLine();
            Console.WriteLine($"Items: {loot.Count}");

            /*
             * Arrays:
             * Length
             *
             * Listen:
             * Count
             */

            /*
             * =========================================
             * ZUFÄLLIGES LOOT
             * =========================================
             */

            List<string> bossLoot = new List<string>()
            {
                "Legendäres Schwert",
                "Drachenrüstung",
                "100 Gold",
                "Mystischer Kristall",
                "Heiltrank"
            };

            Random random = new Random();

            int zufallsIndex =
                random.Next(0, bossLoot.Count);

            Console.WriteLine();
            Console.WriteLine("Boss lässt fallen:");

            Console.WriteLine(
                bossLoot[zufallsIndex]
            );

            /*
             * =========================================
             * MINI-PROJEKT
             * INVENTARSYSTEM
             * =========================================
             */

            List<string> inventarSystem =
                new List<string>();

            inventarSystem.Add("Holzschwert");
            inventarSystem.Add("Apfel");
            inventarSystem.Add("Heiltrank");

            Console.WriteLine();
            Console.WriteLine("=== Inventar ===");

            foreach (string item in inventarSystem)
            {
                Console.WriteLine(item);
            }

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle ein Array mit 5 Städten.
             *
             * Gib alle Städte aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle ein Array mit
             * 5 Schadenswerten.
             *
             * Berechne die Summe.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle eine Liste mit Zaubern.
             *
             * Füge mindestens 3 Zauber hinzu.
             *
             * Gib alle aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle eine Liste mit Items.
             *
             * Entferne eines davon.
             *
             * Gib die Liste erneut aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Erstelle eine Lootliste.
             *
             * Gib ein zufälliges Item aus.
             */

            // Lösung hier


            /*
             * =========================================
             * HÄUFIGE FEHLER
             * =========================================
             *
             * Fehler:
             *
             * string[] namen =
             * {
             *     "Held",
             *     "Magier"
             * };
             *
             * Console.WriteLine(namen[2]);
             *
             * Problem:
             *
             * Es gibt nur Index:
             *
             * 0
             * 1
             *
             * Index 2 existiert nicht.
             */

            /*
             * =========================================
             * BOSSKAMPF
             * ARRAY-OUT-OF-BOUNDS-TITAN
             * =========================================
             *
             * Finde den Fehler:
             *
             * string[] items =
             * {
             *     "Schwert",
             *     "Schild"
             * };
             *
             * Console.WriteLine(items[2]);
             *
             * Fehler:
             *
             * Index 2 existiert nicht.
             *
             * Richtig:
             *
             * items[0]
             * items[1]
             *
             * Oder:
             *
             * Schleife mit Length nutzen.
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 7 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Inventarbeutel");
            Console.WriteLine("+ Lootgenerator");
            Console.WriteLine("+ Listenmeister-Titel");
        }
    }
}