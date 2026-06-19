/*
====================================================
    02 - Variablen
====================================================

Variablen sind kleine Speicherboxen.

Stell dir vor, du arbeitest im Tierheim.
Du brauchst dir Dinge zu merken:

- Name des Tieres
- Alter
- Lieblingssnack
- Ist das Tier schon adoptiert?

Dafür benutzt man Variablen.
*/

/*
====================================================
    let
====================================================

let benutzt man, wenn sich der Wert später ändern kann.

Beispiel:
Ein Tier heißt erst "Unbekannt",
später bekommt es einen Namen.
*/

let tierName = "Unbekannt";

console.log(tierName);

tierName = "Bowser";

console.log(tierName);

/*
Bowser war erst unbekannt.
Dann hat er seinen epischen Boss-Namen bekommen.
*/

/*
====================================================
    const
====================================================

const benutzt man, wenn sich der Wert NICHT ändern soll.

Beispiel:
Der Name des Tierheims bleibt gleich.
*/

const tierheimName = "Super Pfoten Tierheim";

console.log(tierheimName);

/*
Das hier wäre falsch:

tierheimName = "Anderes Tierheim";

Warum?
Weil const bedeutet:
Dieser Wert bleibt fest.

Wie ein Endboss-Tor in Mario.
Da wird nicht einfach umdekoriert.
*/

/*
====================================================
    Gute Variablennamen
====================================================

Gute Namen:
*/

let hundName = "Yoshi";
let katzenAlter = 4;
let lieblingsSnack = "Thunfisch";
let istAdoptiert = false;

/*
Schlechte Namen:
*/

let x = "Yoshi";
let a = 4;
let ding = "Thunfisch";

/*
Warum schlecht?

Weil man später nicht mehr weiß, was gemeint ist.

Code soll nicht klingen wie:
"Da ist das Ding mit dem Dings."

Code soll klingen wie:
"Der Hund heißt Yoshi und liebt Kekse."
*/

console.log(hundName);
console.log(katzenAlter);
console.log(lieblingsSnack);
console.log(istAdoptiert);

/*
====================================================
    Datentypen kurz erklärt
====================================================

String = Text
Number = Zahl
Boolean = true oder false

true bedeutet wahr.
false bedeutet falsch.
*/

let name = "Peach";        // String
let alter = 3;             // Number
let hatHunger = true;      // Boolean

console.log(name);
console.log(alter);
console.log(hatHunger);

/*
====================================================
    Aufgabe 1
====================================================

Erstelle folgende Variablen:

1. deinName
2. deinLieblingstier
3. anzahlSnacks
4. istMarioMüde

Gib alle Werte mit console.log() aus.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle ein Tierheim-Tier:

- tierName
- tierArt
- tierAlter
- istVermittelt

Beispiel:
Name: Luigi
Art: Hund
Alter: 5
Vermittelt: false

Gib danach einen Satz aus:

"Luigi ist ein Hund und ist 5 Jahre alt."
*/

// Deine Lösung hier: