/*
====================================================
    09 - Schleifen: while
====================================================

while bedeutet:
"SOLANGE etwas wahr ist, mach weiter."

Das ist nützlich, wenn du vorher nicht immer genau weißt,
wie oft etwas passieren soll.

Beispiel:

Solange Mario weniger als 10 Münzen hat,
sammelt er weiter.
*/

let muenzen = 0;

while (muenzen < 10) {
    muenzen++;
    console.log(`Mario hat jetzt ${muenzen} Münzen.`);
}

console.log("Mario hat genug Münzen für ein Power-Up.");

/*
====================================================
    Achtung: Endlosschleifen
====================================================

Eine while-Schleife braucht eine Veränderung.

Falsch:

let hunger = true;

while (hunger) {
    console.log("Tier hat Hunger.");
}

Das hört nie auf, weil hunger immer true bleibt.

Das ist wie Bowser im Snackraum mit abgeschlossenem Ausgang.
Chaos für immer.
*/

/*
====================================================
    Beispiel: Tier füttern
====================================================
*/

let hungerPunkte = 5;

while (hungerPunkte > 0) {
    console.log(`Tier hat noch Hunger-Level ${hungerPunkte}. Füttere Snack.`);
    hungerPunkte--;
}

console.log("Tier ist satt und rollt sich ein.");

/*
====================================================
    while oder for?
====================================================

for:
Wenn du ungefähr weißt, wie oft etwas passieren soll.

while:
Wenn etwas solange passieren soll, bis eine Bedingung nicht mehr stimmt.

Beispiel:

for:
Füttere genau 5 Katzen.

while:
Füttere die Katze, solange sie Hunger hat.
*/

/*
====================================================
    Aufgabe 1
====================================================

Erstelle:

let snacks = 0;

Solange snacks kleiner als 5 ist:
- erhöhe snacks um 1
- gib aus: "Snack Nummer X wurde vorbereitet."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle:

let bowserEnergie = 3;

Solange bowserEnergie größer als 0 ist:
- gib aus: "Bowser rennt durchs Tierheim."
- verringere bowserEnergie um 1

Am Ende:
"Bowser schläft."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 3
====================================================

Mario braucht 12 Münzen.
Er startet mit 0 Münzen.

Solange er weniger als 12 Münzen hat:
- sammelt er eine Münze
- gibt aus, wie viele Münzen er hat

Am Ende:
"Mario kann ins Bonuslevel."
*/

// Deine Lösung hier: