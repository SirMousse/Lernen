/*
====================================================
    16 - Objekte
====================================================

Bis jetzt haben wir Tiere oft so gespeichert:

let tierName = "Nala";
let tierArt = "Katze";
let tierAlter = 5;

Das funktioniert.

Aber was passiert bei 50 Tieren?

Dann hast du plötzlich:

tier1Name
tier1Art
tier1Alter

tier2Name
tier2Art
tier2Alter

tier3Name
tier3Art
tier3Alter

...

Das wird schnell schlimmer als Bowsers Keller voller
ungeöffneter Snackpakete.

Dafür gibt es Objekte.
*/

/*
====================================================
    Erstes Objekt
====================================================
*/

let nala = {
    name: "Nala",
    art: "Katze",
    alter: 5
};

console.log(nala);

/*
Ein Objekt besteht aus:

Schlüssel : Wert

name : "Nala"
art : "Katze"
alter : 5

Man nennt diese Werte Eigenschaften
oder Properties.
*/

/*
====================================================
    Werte auslesen
====================================================
*/

console.log(nala.name);
console.log(nala.art);
console.log(nala.alter);

/*
Man spricht:

nala Punkt name
nala Punkt art
nala Punkt alter
*/

/*
====================================================
    Schöne Ausgabe
====================================================
*/

console.log(
    `${nala.name} ist eine ${nala.art} und ${nala.alter} Jahre alt.`
);

/*
====================================================
    Weitere Eigenschaften
====================================================
*/

let bowser = {
    name: "Bowser",
    art: "Hund",
    alter: 7,
    vermittelt: false,
    lieblingsSnack: "Leberwurst"
};

console.log(bowser);

/*
====================================================
    Aufgabe 1
====================================================

Erstelle ein Objekt:

mario

Eigenschaften:

- name
- alter
- muenzen

Gib alle Werte aus.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle ein Objekt:

tierheim

Eigenschaften:

- name
- ort
- anzahlTiere

Gib einen schönen Satz aus.
*/

// Deine Lösung hier: