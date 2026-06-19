/*
====================================================
    30 - APIs
====================================================

Jetzt beginnt das Endgame der Grundlagen.

APIs liefern Daten.

Zum Beispiel:

- Wetter
- Pokémon
- Katzenbilder
- Währungen
- Nachrichten
*/

/*
====================================================
    fetch()
====================================================
*/

fetch(
    "https://pokeapi.co/api/v2/pokemon/pikachu"
)
.then(
    response => response.json()
)
.then(
    data => {

        console.log(data);

    }
);

/*
====================================================
    Was passiert?
====================================================

1. Anfrage wird geschickt

2. Server antwortet

3. JSON wird empfangen

4. Daten werden genutzt
*/

/*
====================================================
    CodeQuest-Bezug
====================================================

Später kannst du APIs nutzen für:

- Ranglisten
- Nutzerdaten
- Achievements
- Multiplayer
- Lernfortschritt
*/

/*
====================================================
    SUPER-BOSS-CHALLENGE
====================================================

Baue irgendwann:

Pokémon Lexikon

oder

Tierheim Manager 3.0

mit:

- HTML
- CSS
- JavaScript
- localStorage

Das ist ein echtes Portfolio-Projekt.
*/