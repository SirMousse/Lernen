/*
====================================================
    MINI-PROJEKT
    Tierheim Manager 1.0
====================================================

Alles was wir bisher gelernt haben:

- Variablen
- Arrays
- Schleifen
- if
- Funktionen

Jetzt bauen wir etwas Größeres.
*/

let tiere = [
    "Nala",
    "Louis",
    "Tiber",
    "Bowser",
    "Yoshi"
];

/*
====================================================
    Tiere anzeigen
====================================================
*/

function zeigeAlleTiere() {

    console.log("===== TIERLISTE =====");

    for (let i = 0; i < tiere.length; i++) {
        console.log(tiere[i]);
    }

}

zeigeAlleTiere();

/*
====================================================
    Tier begrüßen
====================================================
*/

function begruesseTier(name) {
    console.log(`Hallo ${name}!`);
}

begruesseTier("Nala");

/*
====================================================
    Alle Tiere füttern
====================================================
*/

function fuettereAlleTiere() {

    for (let i = 0; i < tiere.length; i++) {

        console.log(`${tiere[i]} bekommt Futter.`);

    }

}

fuettereAlleTiere();

/*
====================================================
    Neues Tier aufnehmen
====================================================
*/

function neuesTier(name) {

    tiere.push(name);

    console.log(`${name} wurde aufgenommen.`);

}

neuesTier("Peach");

zeigeAlleTiere();

/*
====================================================
    Tieranzahl anzeigen
====================================================
*/

function zeigeTierAnzahl() {

    console.log(
        `Aktuell leben ${tiere.length} Tiere im Tierheim.`
    );

}

zeigeTierAnzahl();

/*
====================================================
    CHALLENGE 1
====================================================

Schreibe eine Funktion:

superSnack()

Alle Tiere bekommen einen Super-Snack.
*/

/*
====================================================
    CHALLENGE 2
====================================================

Schreibe eine Funktion:

begruesseAlleTiere()

Ausgabe:

Hallo Nala
Hallo Louis
...
*/

/*
====================================================
    CHALLENGE 3
====================================================

Schreibe:

bossTag()

Ausgabe:

Heute kommt Bowser ins Tierheim.

Wenn Bowser vorhanden:
"Bowser hat alle Snacks geklaut."

Sonst:
"Die Snacks sind sicher."
*/

/*
====================================================
    SUPER-BOSS
====================================================

Erweitere das Projekt um:

- Münzen
- Tierfutter
- Adoptionen
- Tiernamen suchen

Genau solche Projekte bauen echte Entwickler.

Nur mit etwas weniger Bowser.
*/