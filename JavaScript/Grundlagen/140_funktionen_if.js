/*
====================================================
    14 - Funktionen + Entscheidungen
====================================================

Jetzt kombinieren wir Funktionen mit if.

Das wird später ständig gebraucht.
*/

/*
====================================================
    Beispiel
====================================================
*/

function pruefeAlter(alter) {

    if (alter >= 18) {
        console.log("Volljährig");
    } else {
        console.log("Minderjährig");
    }

}

pruefeAlter(20);
pruefeAlter(12);

/*
====================================================
    Tierheim
====================================================
*/

function darfVermitteltWerden(istGeimpft) {

    if (istGeimpft) {
        console.log("Tier darf vermittelt werden.");
    } else {
        console.log("Tier braucht noch Impfungen.");
    }

}

darfVermitteltWerden(true);
darfVermitteltWerden(false);

/*
====================================================
    Mario-Shop
====================================================
*/

function kaufePilz(muenzen) {

    if (muenzen >= 10) {
        console.log("Pilz gekauft.");
    } else {
        console.log("Nicht genug Münzen.");
    }

}

kaufePilz(15);
kaufePilz(4);

/*
====================================================
    return + if
====================================================
*/

function hatGenugMuenzen(muenzen) {

    if (muenzen >= 20) {
        return true;
    } else {
        return false;
    }

}

console.log(hatGenugMuenzen(25));
console.log(hatGenugMuenzen(5));

/*
====================================================
    Kürzere Variante
====================================================
*/

function hatGenugMuenzen2(muenzen) {
    return muenzen >= 20;
}

console.log(hatGenugMuenzen2(25));

/*
====================================================
    Aufgabe 1
====================================================

Erstelle:

istHungrig(hungerPunkte)

Wenn größer als 5:
"Hungrig"

Sonst:
"Satt"
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 2
====================================================

Erstelle:

darfInsSchloss(muenzen)

Wenn mindestens 50 Münzen:
"Zugang erlaubt"

Sonst:
"Noch sammeln"
*/

// Deine Lösung hier:


/*
====================================================
    Aufgabe 3
====================================================

Erstelle:

istSeniorTier(alter)

Wenn alter >= 10

return true

Sonst

return false
*/

// Deine Lösung hier: