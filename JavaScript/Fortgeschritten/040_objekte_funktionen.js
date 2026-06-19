/*
====================================================
    19 - Funktionen mit Objekten
====================================================

Jetzt können Funktionen ganze Objekte bekommen.
*/

let nala = {
    name: "Nala",
    art: "Katze",
    alter: 5
};

function stelleTierVor(tier) {

    console.log(
        `${tier.name} ist eine ${tier.art} und ${tier.alter} Jahre alt.`
    );

}

stelleTierVor(nala);

/*
====================================================
    Tier füttern
====================================================
*/

function fuettereTier(tier) {

    console.log(
        `${tier.name} bekommt einen Super-Snack.`
    );

}

fuettereTier(nala);

/*
====================================================
    Tier vermitteln
====================================================
*/

function vermittleTier(tier) {

    tier.vermittelt = true;

    console.log(
        `${tier.name} wurde vermittelt.`
    );

}

let louis = {
    name: "Louis",
    vermittelt: false
};

vermittleTier(louis);

console.log(louis);

/*
====================================================
    Aufgabe 1
====================================================

Erstelle:

zeigeHeld(held)

Ausgabe:

"NAME besitzt X Münzen."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle:

gibSnack(tier)

Ausgabe:

"NAME bekommt LIEBLINGSSNACK."
*/

// Deine Lösung hier: