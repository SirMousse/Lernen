/*
====================================================
    10 - Arrays
====================================================

Arrays sind Listen.

Im Tierheim gibt es nicht nur ein Tier.
Es gibt viele Tiere.

Statt so:

let tier1 = "Nala";
let tier2 = "Louis";
let tier3 = "Tiber";

nutzen wir ein Array.
*/

let tiere = ["Nala", "Louis", "Tiber"];

console.log(tiere);

/*
====================================================
    Einzelne Werte auslesen
====================================================

Arrays zählen ab 0.

Das ist am Anfang weird,
aber in JavaScript normal.

Index 0 = erstes Element
Index 1 = zweites Element
Index 2 = drittes Element
*/

console.log(tiere[0]); // Nala
console.log(tiere[1]); // Louis
console.log(tiere[2]); // Tiber

/*
Merksatz:

Computer zählen wie kleine Kobolde:
Sie starten bei 0.
*/

/*
====================================================
    Länge eines Arrays
====================================================

.length sagt dir, wie viele Elemente im Array sind.
*/

console.log(tiere.length);

/*
====================================================
    Mit for durch ein Array laufen
====================================================
*/

for (let i = 0; i < tiere.length; i++) {
    console.log(`${tiere[i]} bekommt einen Snack.`);
}

/*
Warum i < tiere.length?

Wenn ein Array 3 Elemente hat,
sind die Indizes:

0, 1, 2

Der letzte Index ist also length - 1.
*/

/*
====================================================
    Neue Werte hinzufügen
====================================================

push() fügt hinten etwas hinzu.
*/

tiere.push("Bowser");

console.log(tiere);

/*
====================================================
    Letzten Wert entfernen
====================================================

pop() entfernt den letzten Wert.
*/

tiere.pop();

console.log(tiere);

/*
====================================================
    Aufgabe 1
====================================================

Erstelle ein Array namens marioItems mit:

- "Pilz"
- "Stern"
- "Feuerblume"

Gib das erste Item aus.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle ein Array namens tierheimTiere mit 4 Tieren.

Gib mit einer for-Schleife aus:

"NAME wartet auf Futter."

Für jedes Tier im Array.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 3
====================================================

Füge mit push() ein neues Tier hinzu.
Gib danach das ganze Array aus.
*/

// Deine Lösung hier: