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
             * KAPITEL 9 - VERERBUNG UND POLYMORPHISMUS
             * =========================================
             *
             * Willkommen in den höheren Künsten der OOP.
             *
             * Bisher hatten wir Klassen:
             *
             * Spieler
             * Gegner
             *
             * Doch was passiert, wenn wir haben:
             *
             * Krieger
             * Magier
             * Bogenschütze
             * Paladin
             * Nekromant
             *
             * Sollen wir überall Name, Level,
             * Lebenspunkte usw. erneut schreiben?
             *
             * Nein.
             *
             * Dafür gibt es Vererbung.
             */

            /*
             * =========================================
             * POLYMORPHISMUS
             * =========================================
             *
             * Alle Klassen erben von Charakter.
             */

            List<Charakter> gruppe =
                new List<Charakter>();

            gruppe.Add(new Krieger("Brutus"));
            gruppe.Add(new Magier("Eldria"));
            gruppe.Add(new Bogenschütze("Robin"));

            Console.WriteLine("=== Heldengruppe ===");

            foreach (Charakter held in gruppe)
            {
                held.StelleVor();
                held.GreifeAn();

                Console.WriteLine();
            }

            /*
             * Obwohl alle Objekte als Charakter
             * gespeichert wurden, wird jeweils die
             * richtige Angriffsmethode ausgeführt.
             *
             * Das nennt man Polymorphismus.
             */

            /*
             * =========================================
             * ABSTRAKTE KLASSEN
             * =========================================
             *
             * Charakter ist abstract.
             *
             * Deshalb geht folgendes NICHT:
             *
             * Charakter test = new Charakter();
             *
             * Warum?
             *
             * Ein allgemeiner Charakter soll
             * niemals direkt existieren.
             */

            /*
             * =========================================
             * IS-OPERATOR
             * =========================================
             */

            Charakter spieler =
                new Magier("Merlin");

            if (spieler is Magier)
            {
                Console.WriteLine("Spieler ist Magier.");
            }

            /*
             * =========================================
             * AS-OPERATOR
             * =========================================
             */

            Magier magier =
                spieler as Magier;

            if (magier != null)
            {
                Console.WriteLine("Umwandlung erfolgreich.");
            }

            /*
             * =========================================
             * MINI-PROJEKT
             * ARENA
             * =========================================
             */

            List<Charakter> arena =
                new List<Charakter>()
                {
                    new Krieger("Thorgrim"),
                    new Magier("Alazar"),
                    new Bogenschütze("Sylva")
                };

            Console.WriteLine();
            Console.WriteLine("=== Arena Kampf ===");

            foreach (Charakter kämpfer in arena)
            {
                kämpfer.GreifeAn();
            }

            /*
             * =========================================
             * INTERFACES
             * =========================================
             *
             * Interfaces definieren Regeln.
             *
             * Wer das Interface nutzt,
             * MUSS die Methoden implementieren.
             */

            Drache drache =
                new Drache("Smolder");

            drache.Fliegen();

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle eine Klasse:
             *
             * Paladin
             *
             * Vererbt von Charakter.
             *
             * Überschreibe GreifeAn().
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle:
             *
             * Nekromant
             *
             * Vererbt von Charakter.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle eine Liste mit:
             *
             * Krieger
             * Magier
             * Bogenschütze
             *
             * Rufe GreifeAn() auf.
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Erstelle ein Interface:
             *
             * ISchwimmen
             *
             * Methode:
             *
             * Schwimmen()
             */

            // Lösung hier


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Erstelle eine Klasse:
             *
             * Hai
             *
             * Implementiert:
             *
             * ISchwimmen
             */

            // Lösung hier


            /*
             * =========================================
             * HÄUFIGE FEHLER
             * =========================================
             *
             * Fehler:
             *
             * class Magier
             * {
             * }
             *
             * Keine Vererbung vorhanden.
             *
             * Richtig:
             *
             * class Magier : Charakter
             * {
             * }
             *
             * -----------------------------------------
             *
             * Fehler:
             *
             * public virtual void Angriff()
             *
             * public void Angriff()
             *
             * override fehlt.
             */

            /*
             * =========================================
             * BOSSKAMPF
             * COPY-PASTE-HYDRA-KÖNIG
             * =========================================
             *
             * Problem:
             *
             * Krieger:
             * Name
             * Level
             * Leben
             *
             * Magier:
             * Name
             * Level
             * Leben
             *
             * Bogenschütze:
             * Name
             * Level
             * Leben
             *
             * Derselbe Code überall.
             *
             * Lösung:
             *
             * Vererbung.
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 9 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Vererbungs-Rune");
            Console.WriteLine("+ Polymorphismus-Siegel");
            Console.WriteLine("+ Hydra-Jäger Titel");
        }
    }

    /*
     * =========================================
     * ABSTRAKTE BASISKLASSE
     * =========================================
     */

    abstract class Charakter
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int Lebenspunkte { get; set; }

        public Charakter(string name)
        {
            Name = name;
            Level = 1;
            Lebenspunkte = 100;
        }

        public void StelleVor()
        {
            Console.WriteLine(
                $"Name: {Name}"
            );
        }

        public abstract void GreifeAn();
    }

    /*
     * =========================================
     * KRIEGER
     * =========================================
     */

    class Krieger : Charakter
    {
        public Krieger(string name)
            : base(name)
        {
        }

        public override void GreifeAn()
        {
            Console.WriteLine(
                $"{Name} schlägt mit dem Schwert zu."
            );
        }
    }

    /*
     * =========================================
     * MAGIER
     * =========================================
     */

    class Magier : Charakter
    {
        public Magier(string name)
            : base(name)
        {
        }

        public override void GreifeAn()
        {
            Console.WriteLine(
                $"{Name} wirkt einen Feuerball."
            );
        }
    }

    /*
     * =========================================
     * BOGENSCHÜTZE
     * =========================================
     */

    class Bogenschütze : Charakter
    {
        public Bogenschütze(string name)
            : base(name)
        {
        }

        public override void GreifeAn()
        {
            Console.WriteLine(
                $"{Name} schießt einen Pfeil."
            );
        }
    }

    /*
     * =========================================
     * INTERFACE
     * =========================================
     */

    interface IFliegen
    {
        void Fliegen();
    }

    /*
     * =========================================
     * DRACHE
     * =========================================
     */

    class Drache : IFliegen
    {
        public string Name { get; set; }

        public Drache(string name)
        {
            Name = name;
        }

        public void Fliegen()
        {
            Console.WriteLine(
                $"{Name} erhebt sich in die Lüfte."
            );
        }
    }
}