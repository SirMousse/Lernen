/*
====================================================
    21 - Methoden
====================================================

Willkommen im Methoden-Level.

Bis jetzt kennen wir bereits:

Variablen
Arrays
Objekte
Funktionen

Nun lernen wir Methoden.

Eine Methode ist vereinfacht gesagt:

Eine Funktion, die zu etwas gehört.

Beispiel:

Ein Hund hat Tricks.

Ein Array hat Methoden.

Ein String hat Methoden.

Ein Objekt kann Methoden haben.

Man könnte sagen:

Methoden sind Spezialfähigkeiten.
Wie Mario-Items.
*/

/*
====================================================
    push()
====================================================

push() fügt etwas am Ende eines Arrays hinzu.
*/

let tiere = ["Nala", "Louis", "Tiber"];

tiere.push("Bowser");

console.log(tiere);

/*
Vorher:

Nala
Louis
Tiber

Nachher:

Nala
Louis
Tiber
Bowser
*/

/*
====================================================
    pop()
====================================================

Entfernt das letzte Element.
*/

tiere.pop();

console.log(tiere);

/*
Bowser wurde wieder entfernt.
Vermutlich wegen Snackdiebstahl.
*/

/*
====================================================
    includes()
====================================================

Prüft:

Ist etwas vorhanden?
*/

let helden = [
    "Mario",
    "Luigi",
    "Peach"
];

console.log(
    helden.includes("Mario")
);

console.log(
    helden.includes("Bowser")
);

/*
Ergebnis:

true
false
*/

/*
====================================================
    indexOf()
====================================================

Wo befindet sich etwas?
*/

console.log(
    helden.indexOf("Luigi")
);

/*
Mario = 0
Luigi = 1
Peach = 2

Ergebnis:

1
*/

/*
====================================================
    Aufgabe 1
====================================================

Erstelle:

let snacks = [
    "Keks",
    "Thunfisch"
];

Füge hinzu:

"Hühnchen"
*/

/*
====================================================
    Aufgabe 2
====================================================

Prüfe:

Ist "Bowser" im Array?
*/

/*
====================================================
    Aufgabe 3
====================================================

Entferne das letzte Element.
*/