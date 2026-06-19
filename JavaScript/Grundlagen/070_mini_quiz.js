/*
====================================================
    07 - Mini-Projekt: Tierheim-Mario-Quiz
====================================================

Jetzt kombinieren wir:

- Variablen
- Strings
- Zahlen
- if
- else
- logische Operatoren

Das ist ein kleines Konsolen-Quiz.
Noch ohne Eingabe vom Nutzer.
Die Antworten stehen erstmal als Variablen im Code.
*/

let frage1 = "Welches Tier sagt Miau?";
let antwort1 = "Katze";

let spielerAntwort1 = "Katze";

if (spielerAntwort1 === antwort1) {
    console.log("Richtig! Die Katze bekommt einen Snack.");
} else {
    console.log("Falsch! Bowser hat den Snack geklaut.");
}

/*
====================================================
    Punkte zählen
====================================================
*/

let punkte = 0;

let antwortMario = "Pilz";

if (antwortMario === "Pilz") {
    punkte = punkte + 1;
    console.log("Richtig! Mario wächst.");
} else {
    console.log("Leider falsch. Mario bleibt klein.");
}

let antwortTierheim = "Hund";

if (antwortTierheim === "Hund") {
    punkte = punkte + 1;
    console.log("Richtig! Der Hund wedelt.");
} else {
    console.log("Falsch. Die Katze schaut enttäuscht.");
}

console.log(`Du hast ${punkte} Punkte erreicht.`);

/*
====================================================
    Kürzer Punkte erhöhen
====================================================

Diese Schreibweise:

punkte = punkte + 1;

kann man kürzer schreiben als:

punkte++;

Das bedeutet:
Erhöhe punkte um 1.
*/

punkte++;

console.log(`Bonuspunkt! Jetzt hast du ${punkte} Punkte.`);

/*
====================================================
    Abschlussbewertung
====================================================
*/

if (punkte >= 3) {
    console.log("Legendär! Du bist Tierheim-Mario-Level-Profi.");
} else if (punkte === 2) {
    console.log("Gut gemacht! Luigi nickt anerkennend.");
} else {
    console.log("Noch üben. Bowser bewacht die Lernunterlagen.");
}

/*
====================================================
    Aufgabe 1
====================================================

Baue ein eigenes Mini-Quiz mit 3 Fragen.

Thema:
Tierheim, Super Mario oder beides.

Lege fest:

- richtigeAntwort1
- spielerAntwort1
- richtigeAntwort2
- spielerAntwort2
- richtigeAntwort3
- spielerAntwort3

Zähle Punkte.

Am Ende gib aus:

"Du hast X von 3 Punkten."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erweitere dein Quiz:

Wenn Punkte 3:
"Perfekt! Superstern aktiviert."

Wenn Punkte 2:
"Gut! Fast wie Luigi an einem guten Tag."

Wenn Punkte 1:
"Okay, aber Bowser lacht noch."

Wenn Punkte 0:
"Game Over. Aber wir respawnen und üben weiter."
*/

// Deine Lösung hier: