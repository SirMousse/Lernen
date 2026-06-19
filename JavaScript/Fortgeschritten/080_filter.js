/*
====================================================
    23 - filter()
====================================================

find()

findet genau EIN Ergebnis.

filter()

findet ALLE passenden Ergebnisse.

Das ist wie:

"Zeige alle Katzen."
*/

/*
====================================================
    Beispieldaten
====================================================
*/

let tiere = [

    {
        name: "Nala",
        art: "Katze"
    },

    {
        name: "Louis",
        art: "Katze"
    },

    {
        name: "Bowser",
        art: "Hund"
    },

    {
        name: "Yoshi",
        art: "Hund"
    }

];

/*
====================================================
    Alle Katzen suchen
====================================================
*/

let katzen = tiere.filter(
    function(tier) {
        return tier.art === "Katze";
    }
);

console.log(katzen);

/*
Ergebnis:

Nala
Louis
*/

/*
====================================================
    Alle Hunde suchen
====================================================
*/

let hunde = tiere.filter(
    function(tier) {
        return tier.art === "Hund";
    }
);

console.log(hunde);

/*
====================================================
    Aufgabe 1
====================================================

Erweitere die Liste.

Suche alle Hunde.
*/

/*
====================================================
    Aufgabe 2
====================================================

Füge ein Alter hinzu.

Filtere alle Tiere:

alter >= 5
*/