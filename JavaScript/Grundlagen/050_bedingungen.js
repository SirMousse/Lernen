/*
====================================================
    05 - if, else und Entscheidungen
====================================================

Jetzt wird JavaScript langsam lebendig.

Mit if und else kann dein Code Entscheidungen treffen.

Wie im Tierheim:

- Hat der Hund Hunger?
- Ist genug Futter da?
- Hat Mario genug Münzen?
- Ist Bowser heute brav?

if bedeutet:
"WENN etwas wahr ist, dann mach das."

else bedeutet:
"SONST mach etwas anderes."
*/

let hundHatHunger = true;

if (hundHatHunger === true) {
    console.log("Der Hund bekommt Futter.");
} else {
    console.log("Der Hund ist satt und macht ein Nickerchen.");
}

/*
====================================================
    Wichtig: ===
====================================================

Mit === vergleichst du Werte.

Beispiel:
*/

let tierName = "Yoshi";

if (tierName === "Yoshi") {
    console.log("Yoshi ist bereit fürs nächste Level.");
}

/*
Nicht verwechseln:

=   Wert zuweisen
=== Wert vergleichen

Beispiel:

let name = "Mario";     // Zuweisung

name === "Mario";       // Vergleich
*/

/*
====================================================
    Zahlen vergleichen
====================================================

Du kannst Zahlen vergleichen:

>   größer als
<   kleiner als
>=  größer oder gleich
<=  kleiner oder gleich
=== genau gleich
!== nicht gleich
*/

let marioMuenzen = 12;
let powerUpPreis = 10;

if (marioMuenzen >= powerUpPreis) {
    console.log("Mario kann das Power-Up kaufen.");
} else {
    console.log("Mario braucht mehr Münzen.");
}

/*
====================================================
    else if
====================================================

else if brauchst du, wenn es mehrere Möglichkeiten gibt.

Beispiel:
Tierheim-Futterstatus.
*/

let futterVorrat = 4;

if (futterVorrat >= 10) {
    console.log("Alles entspannt. Genug Futter da.");
} else if (futterVorrat >= 5) {
    console.log("Futter reicht noch, aber bitte nachkaufen.");
} else {
    console.log("Alarm! Bowser hat fast alles weggefuttert.");
}

/*
====================================================
    Boolean direkt prüfen
====================================================

Wenn eine Variable true oder false ist,
musst du nicht immer === true schreiben.
*/

let katzeSchlaeft = true;

if (katzeSchlaeft) {
    console.log("Pssst. Katze schläft. Niemand atmet laut.");
} else {
    console.log("Katze ist wach. Snacks bereithalten.");
}

/*
====================================================
    Aufgabe 1
====================================================

Erstelle eine Variable:

let tierHatHunger = true;

Wenn das Tier Hunger hat:
"Das Tier bekommt Futter."

Sonst:
"Das Tier ist satt."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Mario hat 8 Münzen.
Ein Pilz kostet 10 Münzen.

Prüfe:

Wenn Mario genug Münzen hat:
"Mario kauft den Pilz."

Sonst:
"Mario muss noch Münzen sammeln."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 3
====================================================

Erstelle eine Variable:

let tierAlter = 2;

Wenn das Tier jünger als 1 ist:
"Baby-Tier"

Wenn das Tier zwischen 1 und 7 ist:
"Erwachsenes Tier"

Sonst:
"Senior-Tier"
*/

// Deine Lösung hier: