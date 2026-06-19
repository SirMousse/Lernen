/*
====================================================
    27 - HTML verändern
====================================================
*/

let text =
    document.getElementById("status");

/*
Vorher:

<p id="status">
    Tier wartet auf Adoption
</p>
*/

text.textContent =
    "Tier wurde vermittelt.";

/*
====================================================
    Button + Text
====================================================
*/

let button =
    document.getElementById(
        "adoption"
    );

button.addEventListener(
    "click",
    function() {

        text.textContent =
            "Nala hat ein Zuhause gefunden.";

    }
);

/*
====================================================
    Challenge
====================================================

Button klicken.

Mario bekommt Münze.

Text aktualisieren.
*/