using System;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 6 - METHODEN
             * =========================================
             *
             * Willkommen in der Werkstatt der Code-Magier.
             *
             * Bisher haben wir den gesamten Code direkt
             * in Main() geschrieben.
             *
             * Das funktioniert...
             *
             * ...aber spätestens bei größeren Programmen
             * wird es unübersichtlich.
             *
             * Lösung:
             *
             * METHODEN
             *
             * Methoden sind wie Zaubersprüche.
             *
             * Statt denselben Code immer wieder zu schreiben,
             * speicherst du ihn in einer Methode und rufst
             * ihn bei Bedarf auf.
             */

            Begrüßung();

            Begrüßung();

            Begrüßung();

            /*
             * Die Methode wurde drei Mal ausgeführt.
             */

            Console.WriteLine();

            int schaden = BerechneSchaden(15, 5);

            Console.WriteLine($"Gesamtschaden: {schaden}");

            Console.WriteLine();

            BegrüßeSpieler("Arthos");
            BegrüßeSpieler("Luna");
            BegrüßeSpieler("Zerax");

            Console.WriteLine();

            bool darfBetreten = PrüfeDungeonZugang(15);

            Console.WriteLine($"Dungeonzugang: {darfBetreten}");

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle eine Methode:
             *
             * ZeigeInventar()
             *
             * Ausgabe:
             *
             * Inventar:
             * - Schwert
             * - Schild
             * - Heiltrank
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle eine Methode:
             *
             * BegrüßeNPC(string name)
             *
             * Ausgabe:
             *
             * Willkommen, [Name]
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle eine Methode:
             *
             * Addiere(int a, int b)
             *
             * Rückgabe:
             *
             * Summe von a und b
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle eine Methode:
             *
             * IstVolljährig(int alter)
             *
             * Rückgabe:
             *
             * true ab 18
             * false unter 18
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Erstelle eine Methode:
             *
             * Würfle()
             *
             * Rückgabe:
             *
             * Zufallszahl zwischen 1 und 6
             */

            // Lösung hier


            /*
             * =========================================
             * MINI-PROJEKT
             * KAMPFSYSTEM
             * =========================================
             */

            Console.WriteLine();
            Console.WriteLine("=== Kampfsimulator ===");

            int spielerAngriff = 12;
            int waffenBonus = 8;

            int gesamtSchaden = BerechneSchaden(
                spielerAngriff,
                waffenBonus
            );

            Console.WriteLine($"Schaden verursacht: {gesamtSchaden}");

            /*
             * =========================================
             * HÄUFIGE FEHLER
             * =========================================
             *
             * Fehler:
             *
             * void Begrüßung()
             * {
             *     Console.WriteLine("Hallo");
             *
             * Fehlende geschweifte Klammer
             *
             * -----------------------------------------
             *
             * Fehler:
             *
             * int Berechne()
             * {
             * }
             *
             * Methode gibt int zurück,
             * aber return fehlt.
             *
             * -----------------------------------------
             *
             * Fehler:
             *
             * Begrüßung;
             *
             * Richtig:
             *
             * Begrüßung();
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 6 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Methodenrolle");
            Console.WriteLine("+ Zauberbibliothek");
        }

        /*
         * =========================================
         * EINFACHE METHODE
         * =========================================
         *
         * void bedeutet:
         *
         * Die Methode gibt nichts zurück.
         */

        static void Begrüßung()
        {
            Console.WriteLine("Willkommen in DotNetia.");
        }

        /*
         * =========================================
         * METHODE MIT PARAMETER
         * =========================================
         *
         * Parameter sind Informationen,
         * die an die Methode übergeben werden.
         */

        static void BegrüßeSpieler(string name)
        {
            Console.WriteLine($"Hallo {name}.");
        }

        /*
         * =========================================
         * METHODE MIT RÜCKGABEWERT
         * =========================================
         *
         * int bedeutet:
         *
         * Diese Methode liefert eine Zahl zurück.
         */

        static int BerechneSchaden(
            int grundSchaden,
            int bonusSchaden
        )
        {
            return grundSchaden + bonusSchaden;
        }

        /*
         * =========================================
         * BOOL ZURÜCKGEBEN
         * =========================================
         */

        static bool PrüfeDungeonZugang(int level)
        {
            if (level >= 10)
            {
                return true;
            }

            return false;
        }
    }
}