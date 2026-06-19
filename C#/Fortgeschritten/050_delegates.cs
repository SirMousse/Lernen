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
             * KAPITEL 15 - DELEGATES UND EVENTS
             * =========================================
             *
             * Willkommen in der Kommunikationszentrale
             * von DotNetia.
             *
             * Bisher haben Klassen direkt miteinander
             * gearbeitet.
             *
             * Jetzt lernen wir:
             *
             * - Delegates
             * - Events
             *
             * Damit können Objekte miteinander
             * kommunizieren, ohne sich direkt zu kennen.
             *
             * Dieses Prinzip wird überall genutzt:
             *
             * - Spiele
             * - Benutzeroberflächen
             * - APIs
             * - Datenbanken
             * - Frameworks
             */

            /*
             * =========================================
             * DELEGATE
             * =========================================
             *
             * Ein Delegate speichert eine Methode.
             *
             * Man kann ihn sich wie eine Fernbedienung
             * vorstellen.
             *
             * Der Delegate weiß:
             *
             * Welche Methode soll ausgeführt werden?
             */

            KampfNachricht nachricht =
                ZeigeNachricht;

            nachricht(
                "Ein Goblin erscheint."
            );

            /*
             * =========================================
             * EVENTS
             * =========================================
             *
             * Events informieren andere Objekte,
             * wenn etwas passiert.
             */

            Spieler spieler = new Spieler();

            spieler.LevelAufgestiegen +=
                GratuliereSpieler;

            spieler.LevelAufstieg();

            /*
             * Der Spieler kennt die Methode
             * GratuliereSpieler nicht.
             *
             * Trotzdem wird sie ausgeführt.
             */

            /*
             * =========================================
             * MEHRERE EVENT-ABONNENTEN
             * =========================================
             */

            spieler.LevelAufgestiegen +=
                SpieleLevelUpSound;

            spieler.LevelAufstieg();

            /*
             * Jetzt reagieren zwei Methoden
             * auf dasselbe Event.
             */

            /*
             * =========================================
             * LAMBDA ALS EVENT
             * =========================================
             */

            spieler.LevelAufgestiegen +=
                () =>
                {
                    Console.WriteLine(
                        "Belohnung erhalten."
                    );
                };

            spieler.LevelAufstieg();

            /*
             * =========================================
             * EVENT MIT DATEN
             * =========================================
             */

            Boss boss = new Boss();

            boss.BossBesiegt +=
                BossBelohnung;

            boss.Besiegen();

            /*
             * =========================================
             * MINI-PROJEKT
             * QUEST-SYSTEM
             * =========================================
             */

            Quest quest = new Quest();

            quest.QuestAbgeschlossen +=
                QuestBelohnung;

            quest.Abschließen();

            /*
             * =========================================
             * WARUM EVENTS?
             * =========================================
             *
             * Ohne Events:
             *
             * Spieler müsste:
             *
             * UI kennen
             * Sounds kennen
             * Quests kennen
             * Achievements kennen
             *
             * Schlechte Architektur.
             *
             * Mit Events:
             *
             * Spieler sendet nur:
             *
             * "LevelUp"
             *
             * Andere Systeme reagieren selbst.
             */

            /*
             * =========================================
             * AUFGABE 1
             * =========================================
             *
             * Erstelle einen Delegate:
             *
             * Nachricht
             *
             * Parameter:
             *
             * string text
             *
             * Erstelle eine Methode,
             * die den Text ausgibt.
             */

            // Aufgabe


            /*
             * =========================================
             * AUFGABE 2
             * =========================================
             *
             * Erstelle ein Event:
             *
             * TürGeöffnet
             *
             * Lasse eine Methode reagieren.
             */

            // Aufgabe


            /*
             * =========================================
             * AUFGABE 3
             * =========================================
             *
             * Erstelle mehrere Event-Abonnenten.
             *
             * Beispiel:
             *
             * Sound
             * Nachricht
             * Belohnung
             */

            // Aufgabe


            /*
             * =========================================
             * AUFGABE 4
             * =========================================
             *
             * Nutze eine Lambda-Funktion
             * als Event-Handler.
             */

            // Aufgabe


            /*
             * =========================================
             * AUFGABE 5
             * =========================================
             *
             * Baue ein Achievement-System.
             *
             * Event:
             *
             * BossBesiegt
             *
             * Ausgabe:
             *
             * Achievement freigeschaltet
             */

            // Aufgabe


            /*
             * =========================================
             * HÄUFIGE FEHLER
             * =========================================
             *
             * Fehler:
             *
             * Event wird ausgelöst,
             * obwohl kein Abonnent existiert.
             *
             * Lösung:
             *
             * Nullprüfung.
             *
             * -----------------------------------------
             *
             * Fehler:
             *
             * Delegate erwartet Parameter,
             * Methode besitzt keine.
             *
             * Signaturen müssen identisch sein.
             */

            /*
             * =========================================
             * BOSSKAMPF
             * EVENT-CHAOS-BESCHWÖRER
             * =========================================
             *
             * Problem:
             *
             * Klassen kennen zu viele andere Klassen.
             *
             * Ergebnis:
             *
             * Spaghetti-Code.
             *
             * Lösung:
             *
             * Events und Delegates.
             *
             * Lose Kopplung.
             */

            Console.WriteLine();
            Console.WriteLine("Kapitel 15 abgeschlossen.");
            Console.WriteLine("Belohnung erhalten:");
            Console.WriteLine("+ Event-Kristall");
            Console.WriteLine("+ Kommunikations-Amulett");
        }

        /*
         * =========================================
         * METHODEN FÜR DELEGATES
         * =========================================
         */

        static void ZeigeNachricht(string text)
        {
            Console.WriteLine(text);
        }

        static void GratuliereSpieler()
        {
            Console.WriteLine(
                "Glückwunsch zum Levelaufstieg."
            );
        }

        static void SpieleLevelUpSound()
        {
            Console.WriteLine(
                "Level-Up Sound abgespielt."
            );
        }

        static void BossBelohnung()
        {
            Console.WriteLine(
                "Legendärer Gegenstand erhalten."
            );
        }

        static void QuestBelohnung()
        {
            Console.WriteLine(
                "Questbelohnung erhalten."
            );
        }
    }

    /*
     * =========================================
     * DELEGATE
     * =========================================
     */

    delegate void KampfNachricht(
        string text
    );

    /*
     * =========================================
     * SPIELER
     * =========================================
     */

    class Spieler
    {
        public event Action LevelAufgestiegen;

        public void LevelAufstieg()
        {
            Console.WriteLine(
                "Spieler steigt ein Level auf."
            );

            LevelAufgestiegen?.Invoke();
        }
    }

    /*
     * =========================================
     * BOSS
     * =========================================
     */

    class Boss
    {
        public event Action BossBesiegt;

        public void Besiegen()
        {
            Console.WriteLine(
                "Boss wurde besiegt."
            );

            BossBesiegt?.Invoke();
        }
    }

    /*
     * =========================================
     * QUEST
     * =========================================
     */

    class Quest
    {
        public event Action QuestAbgeschlossen;

        public void Abschließen()
        {
            Console.WriteLine(
                "Quest abgeschlossen."
            );

            QuestAbgeschlossen?.Invoke();
        }
    }
}