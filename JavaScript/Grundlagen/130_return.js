/*
====================================================
    13 - return
====================================================

Bisher haben unsere Funktionen nur etwas ausgegeben.

Manchmal möchten wir aber etwas zurückgeben.

Dafür gibt es:

return

return bedeutet:

"Hier ist das Ergebnis."
*/

/*
====================================================
    Beispiel
====================================================
*/

function addiere(a, b) {
    return a + b;
}

let ergebnis = addiere(5, 3);

console.log(ergebnis);

/*
Ablauf:

addiere(5,3)

5 + 3

ergibt 8

return gibt 8 zurück

8 landet in ergebnis
*/

/*
====================================================
    Mario-Beispiel
====================================================
*/

function sammleMuenzen(muenzen, neueMuenzen) {
    return muenzen + neueMuenzen;
}

let marioMuenzen = 10;

marioMuenzen = sammleMuenzen(marioMuenzen, 5);

console.log(marioMuenzen);

/*
====================================================
    Tierheim-Beispiel
====================================================
*/

function berechneFutter(tiere) {
    return tiere * 2;
}

let futter = berechneFutter(5);

console.log(futter);

/*
5 Tiere

2 Portionen pro Tier

Ergebnis:

10 Portionen
*/

/*
====================================================
    Wichtige Regel
====================================================

Nach return endet die Funktion.

Alles darunter wird ignoriert.
*/

function test() {

    return "Hallo";

    console.log("Das sieht niemand.");
}

/*
====================================================
    Aufgabe 1
====================================================

Erstelle:

function multipliziere(a, b)

Die Funktion soll a * b zurückgeben.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Mario sammelt Münzen.

Erstelle:

function neueMuenzen(alte, gefunden)

Die Funktion soll die Gesamtzahl zurückgeben.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 3
====================================================

Im Tierheim bekommt jedes Tier 3 Snacks.

Erstelle:

function berechneSnacks(anzahlTiere)

Rückgabe:

anzahlTiere * 3
*/

// Deine Lösung hier: