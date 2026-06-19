/*
====================================================
    06 - Logische Operatoren
====================================================

Manchmal reicht eine Bedingung nicht.

Beispiel:

Ein Hund darf adoptiert werden, wenn:

- er gesund ist
UND
- die Person genug Platz hat

Dafür gibt es logische Operatoren.
*/

/*
====================================================
    && bedeutet UND
====================================================

Beide Bedingungen müssen wahr sein.
*/

let hundIstGesund = true;
let genugPlatz = true;

if (hundIstGesund && genugPlatz) {
    console.log("Der Hund darf adoptiert werden.");
} else {
    console.log("Noch keine Adoption möglich.");
}

/*
====================================================
    || bedeutet ODER
====================================================

Mindestens eine Bedingung muss wahr sein.
*/

let marioHatPilz = false;
let marioHatStern = true;

if (marioHatPilz || marioHatStern) {
    console.log("Mario ist bereit für den Endgegner.");
} else {
    console.log("Mario sollte lieber noch Items sammeln.");
}

/*
====================================================
    ! bedeutet NICHT
====================================================

! dreht true und false um.
*/

let bowserIstBrav = false;

if (!bowserIstBrav) {
    console.log("Bowser kommt heute nicht an die Snack-Schublade.");
}

/*
====================================================
    Beispiel mit Tierheim
====================================================
*/

let tierIstGeimpft = true;
let tierIstGechipt = true;
let adoptantHatZeit = false;

if (tierIstGeimpft && tierIstGechipt && adoptantHatZeit) {
    console.log("Adoption kann starten.");
} else {
    console.log("Es fehlt noch etwas für die Adoption.");
}

/*
====================================================
    Aufgabe 1
====================================================

Erstelle:

let katzeIstGesund = true;
let katzeIstGechipt = false;

Wenn beides true ist:
"Katze kann vermittelt werden."

Sonst:
"Katze braucht noch Vorbereitung."
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Mario darf ins Schloss, wenn:

- er einen Schlüssel HAT
ODER
- Luigi die Tür öffnet

Erstelle passende Variablen und prüfe das.
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 3
====================================================

Erstelle:

let hundIstLaut = true;

Wenn der Hund NICHT laut ist:
"Perfekt für eine ruhige Wohnung."

Sonst:
"Der Hund braucht Menschen mit starken Nerven."
*/

// Deine Lösung hier: