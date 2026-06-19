using System;

namespace CSharpAkademie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * =========================================
             * KAPITEL 5 - SCHLEIFEN
             * =========================================
             *
             * Schleifen wiederholen Code.
             *
             * Nerd-Bild:
             *
             * Eine Schleife ist wie ein Grinding-Spot im RPG.
             * Solange eine Bedingung stimmt, passiert etwas immer wieder.
             *
             * Die wichtigsten Schleifen:
             *
             * for
             * while
             * do while
             */

            /*
             * =========================================
             * FOR-SCHLEIFE
             * =========================================
             */

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Runde: {i}");
            }

            /*
             * Aufbau:
             *
             * for (Startwert; Bedingung; Veränderung)
             * {
             *     Code
             * }
             *
             * int i = 1  -> Start
             * i <= 5     -> läuft solange i kleiner/gleich 5 ist
             * i++        -> i wird nach jeder Runde um 1 erhöht
             */

            /*
             * =========================================
             * WHILE-SCHLEIFE
             * =========================================
             */

            int leben = 3;

            while (leben > 0)
            {
                Console.WriteLine($"Leben übrig: {leben}");
                leben--;
            }

            /*
             * while prüft zuerst die Bedingung.
             * Wenn sie true ist, läuft der Code.
             */

            /*
             * =========================================
             * DO-WHILE-SCHLEIFE
             * =========================================
             */

            int mana = 0;

            do
            {
                Console.WriteLine("Zauber wird mindestens einmal versucht.");
                mana--;
            }
            while (mana > 0);

            /*
             * do while läuft mindestens einmal,
             * auch wenn die Bedingung am Anfang false ist.
             */

            /*
             * =========================================
             * INKREMENT UND DEKREMENT
             * =========================================
             *
             * i++ bedeutet: erhöhe i um 1
             * i-- bedeutet: verringere i um 1
             *
             * i += 5 bedeutet: erhöhe i um 5
             * i -= 2 bedeutet: verringere i um 2
             */

            int punkte = 10;

            punkte++;
            Console.WriteLine(punkte);

            punkte--;
            Console.WriteLine(punkte);

            punkte += 5;
            Console.WriteLine(punkte);

            punkte -= 2;
            Console.WriteLine(punkte);

            /*
             * =========================================
             * ENDLOSSCHLEIFEN
             * =========================================
             *
             * Achtung:
             *
             * Eine Schleife muss irgendwann enden.
             *
             * Gefährlich:
             *
             * while (true)
             * {
             *     Console.WriteLine("Ich laufe für immer.");
             * }
             *
             * Das nennt man Endlosschleife.
             */

            /*
             * =========================================
             * BREAK
             * =========================================
             *
             * break beendet eine Schleife sofort.
             */

            for (int zahl = 1; zahl <= 10; zahl++)
            {
                if (zahl == 5)
                {
                    break;
                }

                Console.WriteLine(zahl);
            }

            /*
             * Ausgabe:
             *
             * 1
             * 2
             * 3
             * 4
             */

            /*
             * =========================================
             * CONTINUE
             * =========================================
             *
             * continue überspringt nur den aktuellen Durchlauf.
             */

            for (int zahl = 1; zahl <= 5; zahl++)
            {
                if (zahl == 3)
                {
                    continue;
                }

                Console.WriteLine(zahl);
            }

            /*
             * Ausgabe:
             *
             * 1
             * 2
             * 4
             * 5
             */

            /*
             * =========================================
             * ZUFALLSZAHLEN
             * =========================================
             *
             * Für Zufallszahlen nutzen wir Random.
             */

            Random zufall = new Random();

            int würfel = zufall.Next(1, 7);

            Console.WriteLine($"Gewürfelt: {würfel}");

            /*
             * zufall.Next(1, 7)
             *
             * erzeugt Zahlen von 1 bis 6.
             *
             * Wichtig:
             * Die obere Grenze ist NICHT dabei.
             */

            /*
             * =========================================
             * MINI-PROJEKT: ZAHLENRATEN
             * =========================================
             */

            Random rng = new Random();
            int geheimeZahl = rng.Next(1, 11);
            int tipp = 0;

            Console.WriteLine("Errate die geheime Zahl zwischen 1 und 10.");

            while (tipp != geheimeZahl)
            {
                Console.WriteLine("Dein Tipp:");
                tipp = Convert.ToInt32(Console.ReadLine());

                if (tipp < geheimeZahl)
                {
                    Console.WriteLine("Zu niedrig.");
                }
                else if (tipp > geheimeZahl)
                {
                    Console.WriteLine("Zu hoch.");
                }
                else
                {
                    Console.WriteLine("Richtig geraten.");
                }
            }

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Gib mit einer for-Schleife die Zahlen
             * von 1 bis 10 aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Gib mit einer for-Schleife alle geraden Zahlen
             * von 2 bis 20 aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle eine while-Schleife.
             *
             * Start:
             * int energie = 5;
             *
             * Solange energie > 0:
             *
             * Gib aus:
             * "Energie: ..."
             *
             * Verringere energie um 1.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle ein Passwort-System.
             *
             * Richtiges Passwort:
             * dungeon
             *
             * Solange das eingegebene Passwort falsch ist,
             * soll erneut gefragt werden.
             *
             * Bei richtiger Eingabe:
             * "Zugang gewährt"
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Erstelle ein Würfelprogramm.
             *
             * Würfle eine Zahl von 1 bis 6.
             * Gib das Ergebnis aus.
             *
             * Wenn eine 6 gewürfelt wird:
             * "Kritischer Treffer"
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF: INFINITE LOOP DRAGON
             * =========================================
             *
             * Finde den Fehler:
             *
             * int leben = 10;
             *
             * while (leben > 0)
             * {
             *     Console.WriteLine(leben);
             * }
             *
             * Problem:
             *
             * leben wird nie verändert.
             * Die Schleife läuft unendlich.
             *
             * Richtige Lösung:
             *
             * int leben = 10;
             *
             * while (leben > 0)
             * {
             *     Console.WriteLine(leben);
             *     leben--;
             * }
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 5 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Schleifen-Amulett");
            Console.WriteLine("+ Anti-Endlos-Loop-Trank");
        }
    }
}