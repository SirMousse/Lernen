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
             * KAPITEL 8 - KLASSEN UND OBJEKTE
             * =========================================
             *
             * Willkommen zum wichtigsten Kapitel bisher.
             *
             * Viele Entwickler sagen:
             *
             * "Jetzt beginnt das echte C#."
             *
             * Warum?
             *
             * Weil C# eine objektorientierte Sprache ist.
             *
             * Das bedeutet:
             *
             * Wir beschreiben Dinge als Objekte.
             *
             * Beispiele:
             *
             * Spieler
             * Gegner
             * Haustiere
             * Waffen
             * Quests
             * Fahrzeuge
             *
             * Alles kann als Objekt dargestellt werden.
             */

            /*
             * =========================================
             * OBJEKT ERSTELLEN
             * =========================================
             */

            Spieler spieler1 = new Spieler();

            spieler1.Name = "Arthos";
            spieler1.Level = 15;
            spieler1.Lebenspunkte = 100;

            Console.WriteLine(spieler1.Name);
            Console.WriteLine(spieler1.Level);
            Console.WriteLine(spieler1.Lebenspunkte);

            /*
             * Spieler = Klasse
             *
             * spieler1 = Objekt
             */

            /*
             * =========================================
             * MEHRERE OBJEKTE
             * =========================================
             */

            Spieler spieler2 = new Spieler();

            spieler2.Name = "Luna";
            spieler2.Level = 22;
            spieler2.Lebenspunkte = 120;

            Console.WriteLine();
            Console.WriteLine("Spieler 2:");

            Console.WriteLine(spieler2.Name);
            Console.WriteLine(spieler2.Level);

            /*
             * Jedes Objekt besitzt eigene Werte.
             */

            /*
             * =========================================
             * METHODEN IN KLASSEN
             * =========================================
             */

            Console.WriteLine();

            spieler1.StelleVor();

            Console.WriteLine();

            spieler2.StelleVor();

            /*
             * =========================================
             * KONSTRUKTOREN
             * =========================================
             *
             * Konstruktoren werden beim Erstellen
             * automatisch ausgeführt.
             */

            Gegner boss =
                new Gegner(
                    "Drachenkönig",
                    500
                );

            Console.WriteLine();
            boss.StelleVor();

            /*
             * =========================================
             * LISTEN MIT OBJEKTEN
             * =========================================
             */

            List<Spieler> spielerListe =
                new List<Spieler>();

            spielerListe.Add(spieler1);
            spielerListe.Add(spieler2);

            Console.WriteLine();
            Console.WriteLine("Alle Spieler:");

            foreach (Spieler spieler in spielerListe)
            {
                Console.WriteLine(spieler.Name);
            }

            /*
             * =========================================
             * MINI-PROJEKT
             * RPG-GRUPPE
             * =========================================
             */

            Spieler tank = new Spieler();
            tank.Name = "Brutus";
            tank.Level = 20;
            tank.Lebenspunkte = 250;

            Spieler heiler = new Spieler();
            heiler.Name = "Eldria";
            heiler.Level = 18;
            heiler.Lebenspunkte = 90;

            Spieler magier = new Spieler();
            magier.Name = "Zerax";
            magier.Level = 21;
            magier.Lebenspunkte = 70;

            List<Spieler> gruppe =
                new List<Spieler>();

            gruppe.Add(tank);
            gruppe.Add(heiler);
            gruppe.Add(magier);

            Console.WriteLine();
            Console.WriteLine("=== Heldengruppe ===");

            foreach (Spieler spieler in gruppe)
            {
                spieler.StelleVor();
            }

            /*
             * =========================================
             * NULL
             * =========================================
             *
             * Einer der wichtigsten Begriffe in C#.
             *
             * null bedeutet:
             *
             * Es existiert kein Objekt.
             */

            Spieler unbekannt = null;

            /*
             * Das ist erlaubt.
             */

            /*
             * =========================================
             * NULLREFERENCEEXCEPTION
             * =========================================
             *
             * Der Erzfeind aller Anfänger.
             *
             * FALSCH:
             *
             * Spieler test = null;
             * Console.WriteLine(test.Name);
             *
             * Warum?
             *
             * test existiert nicht.
             */

            /*
             * =========================================
             * NULL PRÜFEN
             * =========================================
             */

            if (unbekannt != null)
            {
                Console.WriteLine(unbekannt.Name);
            }
            else
            {
                Console.WriteLine("Kein Spieler vorhanden.");
            }

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle ein Objekt:
             *
             * Spieler
             *
             * Weise Name, Level und Leben zu.
             *
             * Gib alles aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle 3 Spieler.
             *
             * Speichere sie in einer Liste.
             *
             * Gib alle Namen aus.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle eine Klasse:
             *
             * Haustier
             *
             * Eigenschaften:
             *
             * Name
             * Tierart
             *
             * Methode:
             *
             * StelleVor()
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle eine Klasse:
             *
             * Waffe
             *
             * Eigenschaften:
             *
             * Name
             * Schaden
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Erstelle einen Gegner
             * mit Konstruktor.
             *
             * Gib ihn aus.
             */

            // Lösung hier


            /*
             * =========================================
             * BOSSKAMPF
             * NULLREFERENCE NECROMANCER
             * =========================================
             *
             * Finde den Fehler:
             *
             * Spieler held = null;
             *
             * Console.WriteLine(held.Name);
             *
             * Problem:
             *
             * held existiert nicht.
             *
             * Lösung:
             *
             * if(held != null)
             * {
             *     Console.WriteLine(held.Name);
             * }
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 8 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ OOP-Amulett");
            Console.WriteLine("+ Klassenbibliothek");
            Console.WriteLine("+ Schutz gegen NullReferenceException");
        }
    }

    /*
     * =========================================
     * KLASSE SPIELER
     * =========================================
     */

    class Spieler
    {
        /*
         * Eigenschaften
         */

        public string Name { get; set; }

        public int Level { get; set; }

        public int Lebenspunkte { get; set; }

        /*
         * Methode
         */

        public void StelleVor()
        {
            Console.WriteLine(
                $"Name: {Name}, " +
                $"Level: {Level}, " +
                $"Leben: {Lebenspunkte}"
            );
        }
    }

    /*
     * =========================================
     * KLASSE GEGNER
     * =========================================
     */

    class Gegner
    {
        public string Name { get; set; }

        public int Lebenspunkte { get; set; }

        /*
         * Konstruktor
         */

        public Gegner(
            string name,
            int lebenspunkte
        )
        {
            Name = name;
            Lebenspunkte = lebenspunkte;
        }

        public void StelleVor()
        {
            Console.WriteLine(
                $"Boss: {Name} " +
                $"({Lebenspunkte} HP)"
            );
        }
    }
}