/*
====================================================
    26 - Buttons und Events
====================================================

Events sind Ereignisse.

Zum Beispiel:

- Klick
- Tastendruck
- Mausbewegung

JavaScript kann darauf reagieren.
*/

/*
====================================================
    HTML
====================================================

<button id="futterButton">
    Tiere füttern
</button>
*/

/*
====================================================
    JavaScript
====================================================
*/

let button =
    document.getElementById(
        "futterButton"
    );

button.addEventListener(
    "click",
    function() {

        console.log(
            "Alle Tiere wurden gefüttert."
        );

    }
);

/*
====================================================
    Mario-Vergleich
====================================================

Spieler springt.

Event wird ausgelöst.

Mario springt.
*/

/*
====================================================
    Aufgabe
====================================================

Erstelle einen Button.

Beim Klick:

"Bowser hat den Snack geklaut."
*/