/*
====================================================
    12 - Funktionen
====================================================

Bis jetzt haben wir einfach Code von oben nach unten geschrieben.

Das funktioniert.

Aber stell dir vor:

Im Tierheim müssen heute gefüttert werden:

- Nala
- Louis
- Tiber
- Bowser
- Yoshi

Ohne Funktionen:

console.log("Nala bekommt Futter.");
console.log("Louis bekommt Futter.");
console.log("Tiber bekommt Futter.");
console.log("Bowser bekommt Futter.");
console.log("Yoshi bekommt Futter.");

Das wird schnell nervig.

Dafür gibt es Funktionen.

Eine Funktion ist wie ein Zauberspruch.

Du schreibst ihn einmal.
Danach kannst du ihn beliebig oft benutzen.
*/

/*
====================================================
    Erste Funktion
====================================================
*/

function begruessung() {
    console.log("Willkommen im Super Pfoten Tierheim!");
}

begruessung();

/*
Was passiert?

1. Die Funktion wird erstellt.
2. Nichts passiert sofort.
3. Erst beim Aufruf läuft der Code.

Aufruf:

begruessung();
*/

/*
====================================================
    Mehrfach aufrufen
====================================================
*/

begruessung();
begruessung();
begruessung();

/*
Das spart unglaublich viel Arbeit.
*/

/*
====================================================
    Funktion mit Parameter
====================================================

Parameter sind Informationen,
die wir der Funktion mitgeben.

Beispiel:

Welches Tier soll gefüttert werden?
*/

function fuettereTier(name) {
    console.log(`${name} bekommt einen Snack.`);
}

fuettereTier("Nala");
fuettereTier("Louis");
fuettereTier("Bowser");

/*
name ist eine Platzhalter-Variable.

Sie wird erst beim Aufruf gefüllt.
*/

/*
====================================================
    Mehrere Parameter
====================================================
*/

function tierVorstellen(name, art, alter) {
    console.log(`${name} ist ein ${art} und ${alter} Jahre alt.`);
}

tierVorstellen("Nala", "Katze", 5);
tierVorstellen("Yoshi", "Hund", 3);

/*
Reihenfolge ist wichtig.

name
art
alter

dürfen nicht vertauscht werden.
*/

/*
====================================================
    Aufgabe 1
====================================================

Erstelle eine Funktion:

begruesseMario()

Ausgabe:

"Willkommen im Pilzkönigreich!"
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle:

zeigeHeld(name)

Ausgabe:

"NAME betritt das nächste Level."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 3
====================================================

Erstelle:

zeigeTier(name, art)

Ausgabe:

"NAME ist ein/e ART."
*/

// Deine Lösung hier: