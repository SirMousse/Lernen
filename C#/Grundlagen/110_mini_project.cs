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
             * KAPITEL 10 - EXCEPTION HANDLING
             * FEHLERBEHANDLUNG WIE EIN PROFI
             * =========================================
             *
             * Willkommen in den Katakomben der Bugs.
             *
             * Bisher konnten unsere Programme abstürzen.
             *
             * Beispiel:
             */

            // int zahl = Convert.ToInt32("Katze");

            /*
             * Ergebnis:
             *
             * System.FormatException
             *
             * Das Programm beendet sich.
             *
             * Nicht ideal.
             *
             * Deshalb lernen wir jetzt:
             *
             * try
             * catch
             * finally
             * throw
             *
             * Damit können wir Fehler abfangen
             * und kontrolliert behandeln.
             */

            /*
             * =========================================
             * TRY UND CATCH
             * =========================================
             */

            try
            {
                Console.WriteLine("Gib eine Zahl ein:");

                int zahl =
                    Convert.ToInt32(
                        Console.ReadLine()
                    );

                Console.WriteLine(
                    $"Eingegeben: {zahl}"
                );
            }
            catch
            {
                Console.WriteLine(
                    "Ungültige Eingabe."
                );
            }

            /*
             * Wenn ein Fehler entsteht,
             * springt das Programm in catch.
             */

            /*
             * =========================================
             * SPEZIFISCHE FEHLER
             * =========================================
             */

            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(
                    "Division durch Null."
                );
            }

            /*
             * Gute Praxis:
             *
             * Möglichst konkrete Exceptions abfangen.
             */

            /*
             * =========================================
             * EXCEPTION-OBJEKT
             * =========================================
             */

            try
            {
                int level =
                    Convert.ToInt32("Magier");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Fehler: {ex.Message}"
                );
            }

            /*
             * ex enthält Informationen
             * über den Fehler.
             */

            /*
             * =========================================
             * FINALLY
             * =========================================
             *
             * Wird IMMER ausgeführt.
             *
             * Egal ob Fehler auftritt oder nicht.
             */

            try
            {
                Console.WriteLine(
                    "Dungeon wird betreten..."
                );
            }
            catch
            {
                Console.WriteLine(
                    "Fehler im Dungeon."
                );
            }
            finally
            {
                Console.WriteLine(
                    "Dungeon wird geschlossen."
                );
            }

            /*
             * =========================================
             * THROW
             * =========================================
             *
             * Fehler selbst auslösen.
             */

            try
            {
                int level = 3;

                if (level < 10)
                {
                    throw new Exception(
                        "Level zu niedrig."
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    ex.Message
                );
            }

            /*
             * =========================================
             * TRY PARSE
             * =========================================
             *
             * Profi-Methode für Benutzereingaben.
             *
             * Verhindert viele Exceptions.
             */

            Console.WriteLine();
            Console.WriteLine(
                "Bitte Zahl eingeben:"
            );

            string eingabe =
                Console.ReadLine();

            bool erfolgreich =
                int.TryParse(
                    eingabe,
                    out int wert
                );

            if (erfolgreich)
            {
                Console.WriteLine(
                    $"Zahl: {wert}"
                );
            }
            else
            {
                Console.WriteLine(
                    "Keine gültige Zahl."
                );
            }

            /*
             * =========================================
             * DATEIEN LESEN
             * =========================================
             *
             * Auch Dateizugriffe können fehlschlagen.
             */

            try
            {
                string text =
                    File.ReadAllText(
                        "daten.txt"
                    );

                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(
                    "Datei nicht gefunden."
                );
            }

            /*
             * =========================================
             * EIGENE EXCEPTIONS
             * =========================================
             */

            try
            {
                PrüfeLevel(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    ex.Message
                );
            }

            /*
             * =========================================
             * MINI-PROJEKT
             * SICHERE ZAHLENEINGABE
             * =========================================
             */

            bool gültig = false;

            while (!gültig)
            {
                Console.WriteLine(
                    "Level eingeben:"
                );

                string levelText =
                    Console.ReadLine();

                if (
                    int.TryParse(
                        levelText,
                        out int level
                    )
                )
                {
                    Console.WriteLine(
                        $"Level gespeichert: {level}"
                    );

                    gültig = true;
                }
                else
                {
                    Console.WriteLine(
                        "Bitte nur Zahlen eingeben."
                    );
                }
            }

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Frage eine Zahl ab.
             *
             * Nutze try/catch.
             *
             * Gib bei Fehler:
             *
             * "Ungültige Zahl"
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Teile zwei Zahlen.
             *
             * Fange Division durch Null ab.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Nutze TryParse.
             *
             * Frage das Alter ab.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle eine Methode:
             *
             * PrüfeGold(int gold)
             *
             * Wenn gold < 0:
             * throw Exception
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Versuche eine Datei zu lesen.
             *
             * Fange FileNotFoundException ab.
             */

            // Lösung hier


            /*
             * =========================================
             * HÄUFIGE FEHLER
             * =========================================
             *
             * Fehler:
             *
             * catch()
             *
             * Falsch.
             *
             * Richtig:
             *
             * catch
             *
             * oder
             *
             * catch(Exception ex)
             *
             * -------------------------
             *
             * Fehler:
             *
             * int zahl =
             * Convert.ToInt32(
             *     Console.ReadLine()
             * );
             *
             * Ohne Fehlerbehandlung.
             *
             * Risiko:
             *
             * Programmabsturz.
             */

            /*
             * =========================================
             * BOSSKAMPF
             * UNHANDLED EXCEPTION LICH
             * =========================================
             *
             * Finde den Fehler:
             *
             * int zahl =
             * Convert.ToInt32(
             *     Console.ReadLine()
             * );
             *
             * Problem:
             *
             * Benutzer gibt:
             *
             * Katze
             *
             * ein.
             *
             * Ergebnis:
             *
             * Absturz.
             *
             * Lösung:
             *
             * try/catch
             *
             * oder
             *
             * int.TryParse()
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 10 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Fehlerfänger-Rune");
            Console.WriteLine("+ Schutzschild gegen Abstürze");
            Console.WriteLine("+ Titel: Bug-Jäger");
        }

        /*
         * =========================================
         * EIGENE PRÜFMETHODE
         * =========================================
         */

        static void PrüfeLevel(int level)
        {
            if (level < 10)
            {
                throw new Exception(
                    "Mindestlevel 10 erforderlich."
                );
            }
        }
    }
}