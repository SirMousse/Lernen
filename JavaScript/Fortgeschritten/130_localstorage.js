/*
====================================================
    28 - localStorage
====================================================

localStorage ist wie eine Save-Datei.

Wenn der Browser geschlossen wird:

Daten bleiben erhalten.
*/

/*
====================================================
    Speichern
====================================================
*/

localStorage.setItem(
    "tierName",
    "Nala"
);

/*
====================================================
    Lesen
====================================================
*/

let tierName =
    localStorage.getItem(
        "tierName"
    );

console.log(tierName);

/*
====================================================
    Löschen
====================================================
*/

localStorage.removeItem(
    "tierName"
);

/*
====================================================
    Warum cool?
====================================================

Tierheim Manager speichern

Mario Münzen speichern

Highscores speichern

Einstellungen speichern
*/