/*
====================================================
    11 - Mini-Projekt: Tierheim-Fütterungsrunde
====================================================

Wir bauen eine kleine Fütterungsliste.

Ziel:
Alle Tiere im Array sollen begrüßt und gefüttert werden.
*/

let tierListe = ["Nala", "Louis", "Tiber", "Yoshi", "Bowser"];

console.log("Die Fütterungsrunde startet!");

for (let i = 0; i < tierListe.length; i++) {
    console.log(`${tierListe[i]} wird begrüßt.`);
    console.log(`${tierListe[i]} bekommt einen Snack.`);
    console.log("--------------------");
}

console.log("Alle Tiere sind satt. Mario bekommt auch einen Keks.");

/*
====================================================
    Erweiterung: Lieblingssnacks
====================================================
*/

let snacks = ["Thunfisch", "Hühnerkeks", "Käsewürfel", "Apfelstück", "Boss-Keks"];

for (let i = 0; i < tierListe.length; i++) {
    console.log(`${tierListe[i]} bekommt: ${snacks[i]}`);
}

/*
====================================================
    Wichtiger Hinweis
====================================================

Das funktioniert hier nur gut, weil beide Arrays gleich lang sind.

tierListe[0] gehört zu snacks[0]
tierListe[1] gehört zu snacks[1]
tierListe[2] gehört zu snacks[2]

Später lernen wir Objekte.
Dann können wir Tierdaten schöner speichern.
*/

/*
====================================================
    Aufgabe 1
====================================================

Erstelle zwei Arrays:

let helden = [...]
let items = [...]

Beispiel:
Mario bekommt Pilz
Luigi bekommt Stern
Peach bekommt Feuerblume

Gib mit einer Schleife aus:

"HELD bekommt ITEM."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle:

let tiere = [...]
let adoptionStatus = [...]

Beispiel:
Nala = true
Bowser = false

Gib aus:

Wenn true:
"Nala wurde adoptiert."

Wenn false:
"Bowser wartet noch auf sein Für-immer-Zuhause."
*/

// Deine Lösung hier:


/*
====================================================
    Boss-Aufgabe
====================================================

Erstelle ein Array mit 5 Münzwerten:

let muenzWerte = [1, 5, 2, 10, 3];

Berechne mit einer Schleife die Gesamtsumme.

Am Ende:
"Mario hat insgesamt X Münzen gesammelt."
*/

// Deine Lösung hier: