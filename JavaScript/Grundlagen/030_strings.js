/*
====================================================
    03 - Strings
====================================================

Strings sind Texte.

Ein String steht in Anführungszeichen.

Beispiele:
*/

let held = "Mario";
let tier = "Katze";
let snack = "Leckerli";

console.log(held);
console.log(tier);
console.log(snack);

/*
Du kannst einfache oder doppelte Anführungszeichen benutzen:

"Hallo"
'Hallo'

Wichtig:
Fang mit einem Zeichen an und hör mit dem gleichen auf.
*/

let satz1 = "Mario rettet keine Prinzessin, sondern eine Katze.";
let satz2 = 'Luigi bringt Hundefutter mit.';

console.log(satz1);
console.log(satz2);

/*
====================================================
    Strings zusammenbauen
====================================================

Du kannst Texte mit + verbinden.
Das nennt man Konkatenation.

Klingt unnötig kompliziert.
Heißt aber einfach:
Texte zusammenkleben.
*/

let tierName = "Nala";
let tierArt = "Katze";

console.log(tierName + " ist eine " + tierArt + ".");

/*
Achtung:
Leerzeichen musst du selbst einbauen.

Falsch:
*/

console.log(tierName + "ist eine" + tierArt);

/*
Besser:
*/

console.log(tierName + " ist eine " + tierArt + ".");

/*
====================================================
    Template Strings
====================================================

Moderner und angenehmer sind Template Strings.

Die schreibt man mit Backticks:

`Text`

In Template Strings kannst du Variablen mit ${} einsetzen.
*/

let name = "Yoshi";
let art = "Hund";
let alter = 6;

console.log(`${name} ist ein ${art} und ist ${alter} Jahre alt.`);

/*
Das ist oft lesbarer als ganz viel + + + Chaos.

Super-Mario-Vergleich:

Mit + ist es wie:
Block + Block + Block + Block

Mit Template Strings ist es wie:
Ein schöner fertiger Level-Abschnitt.
*/

/*
====================================================
    Aufgabe 1
====================================================

Erstelle diese Variablen:

- heldName
- tierName
- powerUp

Gib dann diesen Satz mit einem Template String aus:

"Mario findet Nala und gibt ihr einen Super-Snack."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle ein Tier mit:

- name
- art
- lieblingsessen
- alter

Gib danach einen schönen Satz aus.

Beispiel:
"Bowser ist ein Hund, ist 7 Jahre alt und liebt Käsekekse."
*/

// Deine Lösung hier: