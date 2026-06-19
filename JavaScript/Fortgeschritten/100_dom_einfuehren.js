/*
====================================================
    25 - DOM
====================================================

HERZLICHEN GLÜCKWUNSCH

Du verlässt jetzt die reine Konsole.

Ab hier wird JavaScript sichtbar.

Ab jetzt:

Buttons
Texte
Bilder
Formulare

Alles wird möglich.
*/

/*
====================================================
    Was ist DOM?
====================================================

DOM bedeutet:

Document Object Model

Klingt furchtbar.

Bedeutet aber:

JavaScript kann HTML sehen.
*/

/*
====================================================
    Beispiel HTML
====================================================

<h1 id="titel">Tierheim</h1>

JavaScript kann darauf zugreifen.
*/

/*
====================================================
    Element finden
====================================================
*/

let titel =
    document.getElementById("titel");

console.log(titel);

/*
====================================================
    Text ändern
====================================================
*/

titel.textContent =
    "Super Pfoten Tierheim";

/*
Jetzt verändert JavaScript die Webseite.
*/

/*
====================================================
    Mario-Vergleich
====================================================

HTML baut den Level.

JavaScript verändert den Level
während du spielst.
*/

/*
====================================================
    WICHTIG
====================================================

DOM funktioniert nur:

Im Browser

NICHT in reinem Node.js.
*/