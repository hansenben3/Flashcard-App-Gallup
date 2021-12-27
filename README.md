# Flashcard-App-Gallup

Home page includes a Create Deck Button that leads to a new form that allows the creation of a deck with a name and description
You are able to create a deck with no description or name

After creating a deck the deck will show up on the home page from there you can choose to delete it, edit it, add a card, or view it

The add a card button will allow you to add a card faster and from the home page

Viewing it will allow you to goto the main page of that deck where you can see all of the cards in it. Front and Back

Editing it will allow you to change the name or description of the deck... also you will be able to edit, add, and delete cards
after creating a card the page will change back to the home page adding multiple cards is best done with home page add a card feature

*Didn't realize that [System.Serializable] was not a Unity thing until I tried it and ran with it...
Had a custom serializing script that turned the deck and flashcards into strings and put them pack into objects of those classes with the serialize and deserialize functions
ended up removing it because it was not necessary and wouldn't save multiple cards

uses a simple save system to a save.txt file that I have used with unity just for simple saving to Persistent data paths...
