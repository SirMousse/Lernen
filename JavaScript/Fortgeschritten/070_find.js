/*
====================================================
    22 - find()
====================================================

find() ist eine der coolsten Methoden überhaupt.

Warum?

Weil man damit gezielt etwas suchen kann.

Zum Beispiel:

Suche Nala.
Suche Bowser.
Suche Mario.
*/

/*
====================================================
    Beispieldaten
====================================================
*/

let tiere = [

    {
        name: "Nala",
        alter: 5
    },

    {
        name: "Louis",
        alter: 3
    },

    {
        name: "Bowser",
        alter: 7
    }

];

/*
====================================================
    Tier suchen
====================================================
*/

let gefundenesTier = tiere.find(
    function(tier) {
        return tier.name === "Bowser";
    }
);

console.log(gefundenesTier);

/*
Ergebnis:

{
    name: "Bowser",
    alter: 7
}
*/

/*
====================================================
    Erklärung
====================================================

JavaScript schaut jedes Tier an.

Ist der Name Bowser?

Ja?

Dann wird dieses Objekt zurückgegeben.
*/

/*
====================================================
    Praktisches Beispiel
====================================================
*/

let nala = tiere.find(
    function(tier) {
        return tier.name === "Nala";
    }
);

console.log(nala);

/*
====================================================
    Aufgabe 1
====================================================

Suche Louis.
*/

/*
====================================================
    Aufgabe 2
====================================================

Erstelle ein Helden-Array.

Suche Mario.
*/