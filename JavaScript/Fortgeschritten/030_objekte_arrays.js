/*
====================================================
    18 - Arrays voller Objekte
====================================================

JETZT wird es interessant.

Statt:

let tiere = ["Nala", "Louis", "Tiber"];

speichern wir richtige Tierdaten.
*/

let tiere = [

    {
        name: "Nala",
        art: "Katze",
        alter: 5
    },

    {
        name: "Louis",
        art: "Katze",
        alter: 3
    },

    {
        name: "Tiber",
        art: "Katze",
        alter: 8
    }

];

console.log(tiere);

/*
====================================================
    Einzelne Werte lesen
====================================================
*/

console.log(tiere[0].name);
console.log(tiere[1].art);
console.log(tiere[2].alter);

/*
tiere[0]

bedeutet:

erstes Tier

.name

bedeutet:

Name des ersten Tieres
*/

/*
====================================================
    Schleife über alle Tiere
====================================================
*/

for (let i = 0; i < tiere.length; i++) {

    console.log(
        `${tiere[i].name} ist ${tiere[i].alter} Jahre alt.`
    );

}

/*
====================================================
    Tierheim Ausgabe
====================================================
*/

for (let i = 0; i < tiere.length; i++) {

    let tier = tiere[i];

    console.log(
        `${tier.name} (${tier.art}) wartet auf Futter.`
    );

}

/*
====================================================
    Aufgabe 1
====================================================

Erstelle ein Array mit 3 Mario-Helden.

Jeder Held soll haben:

- name
- muenzen

Gib alle Helden aus.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle ein Array mit 4 Tieren.

Gib aus:

NAME ist ART.
*/

// Deine Lösung hier: