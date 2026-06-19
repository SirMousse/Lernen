/*
====================================================
    TIERHEIM MANAGER 2.0
====================================================

Jetzt fühlt sich das Ganze langsam
wie eine echte Anwendung an.
*/

let tiere = [

    {
        name: "Nala",
        art: "Katze",
        alter: 5,
        vermittelt: false
    },

    {
        name: "Louis",
        art: "Katze",
        alter: 3,
        vermittelt: true
    },

    {
        name: "Bowser",
        art: "Hund",
        alter: 7,
        vermittelt: false
    }

];

/*
====================================================
    Alle Tiere anzeigen
====================================================
*/

function zeigeAlleTiere() {

    console.log("===== TIERLISTE =====");

    for (let i = 0; i < tiere.length; i++) {

        let tier = tiere[i];

        console.log(
            `${tier.name} | ${tier.art} | ${tier.alter}`
        );

    }

}

zeigeAlleTiere();

/*
====================================================
    Vermittlungsstatus
====================================================
*/

function zeigeVermittlungen() {

    console.log("===== VERMITTLUNGEN =====");

    for (let i = 0; i < tiere.length; i++) {

        let tier = tiere[i];

        if (tier.vermittelt) {

            console.log(
                `${tier.name} hat ein Zuhause gefunden.`
            );

        } else {

            console.log(
                `${tier.name} wartet noch.`
            );

        }

    }

}

zeigeVermittlungen();

/*
====================================================
    Tier suchen
====================================================
*/

function sucheTier(name) {

    for (let i = 0; i < tiere.length; i++) {

        if (tiere[i].name === name) {

            console.log(
                `${name} wurde gefunden!`
            );

            return;
        }

    }

    console.log(
        `${name} wurde leider nicht gefunden.`
    );

}

sucheTier("Bowser");
sucheTier("Yoshi");

/*
====================================================
    Neues Tier aufnehmen
====================================================
*/

function neuesTier(name, art, alter) {

    let tier = {
        name: name,
        art: art,
        alter: alter,
        vermittelt: false
    };

    tiere.push(tier);

}

neuesTier("Yoshi", "Hund", 2);

zeigeAlleTiere();

/*
====================================================
    CHALLENGE 1
====================================================

Schreibe:

vermittleTier(name)

Suche das Tier.

Setze vermittelt auf true.
*/

/*
====================================================
    CHALLENGE 2
====================================================

Schreibe:

zeigeSenioren()

Alle Tiere ab 10 Jahren anzeigen.
*/

/*
====================================================
    CHALLENGE 3
====================================================

Schreibe:

zaehleKatzen()

Wie viele Katzen leben im Tierheim?
*/

/*
====================================================
    SUPER-BOSS
====================================================

Baue ein Menü-System.

1 = Tiere anzeigen
2 = Tier aufnehmen
3 = Vermittlungen anzeigen
4 = Tier suchen

(Das machen wir später mit Benutzereingaben.)
*/