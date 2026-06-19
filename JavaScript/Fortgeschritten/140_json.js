/*
====================================================
    29 - JSON
====================================================

JSON ist DAS Transportmittel im Internet.

Fast jede API nutzt JSON.
*/

/*
====================================================
    Objekt
====================================================
*/

let tier = {
    name: "Nala",
    alter: 5
};

/*
====================================================
    Objekt -> JSON
====================================================
*/

let jsonText =
    JSON.stringify(tier);

console.log(jsonText);

/*
====================================================
    JSON -> Objekt
====================================================
*/

let objekt =
    JSON.parse(jsonText);

console.log(objekt);

/*
====================================================
    Merksatz
====================================================

JSON ist wie eine Transportbox.

Objekt rein.

Internet.

Objekt wieder raus.
*/