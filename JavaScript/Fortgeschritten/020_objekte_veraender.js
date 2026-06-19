/*
====================================================
    17 - Objekte verändern
====================================================

Objekte sind nicht in Stein gemeißelt.

Wir können Werte ändern.
*/

let nala = {
    name: "Nala",
    alter: 5
};

console.log(nala);

/*
====================================================
    Eigenschaft ändern
====================================================
*/

nala.alter = 6;

console.log(nala);

/*
Nala hatte Geburtstag.
*/

/*
====================================================
    Neue Eigenschaft hinzufügen
====================================================
*/

nala.lieblingsSnack = "Thunfisch";

console.log(nala);

/*
====================================================
    Eigenschaft überschreiben
====================================================
*/

nala.lieblingsSnack = "Hühnchen";

console.log(nala);

/*
====================================================
    Boolean ändern
====================================================
*/

nala.vermittelt = false;

console.log(nala);

nala.vermittelt = true;

console.log(nala);

/*
====================================================
    Tierheim Beispiel
====================================================
*/

let tier = {
    name: "Louis",
    vermittelt: false
};

if (!tier.vermittelt) {

    console.log(
        `${tier.name} wartet auf sein Für-immer-Zuhause.`
    );

}

tier.vermittelt = true;

if (tier.vermittelt) {

    console.log(
        `${tier.name} wurde erfolgreich vermittelt.`
    );

}

/*
====================================================
    Aufgabe 1
====================================================

Erstelle:

let mario = {
    name: "Mario",
    muenzen: 10
};

Erhöhe die Münzen auf 20.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle ein Tier.

Füge später hinzu:

lieblingsSpielzeug
*/

// Deine Lösung hier: