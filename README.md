# GameDev
Game Notes

This is us trying to develop a game.
Project Completeion: 

$(document).ready(function(){
$("#progressbar").progressbar({value: 0});
var progress = setInterval(function(){
    var currentVal = $("#progressbar").progressbar("option", "value");
    var nextVal = currentVal + 1;
    if (nextVal > 100){
        clearInterval(progress);
    }else{
        $("#progressbar").progressbar({value: nextVal});
    }
});
});
TO work on this we're going to start with character development and story.
Charcters are going to be unit dev.

Unit variables - NPC's, Characters

Structure variables. - Buildings, Signs

Destructibles. - Trees, Items, Chests

TechTree Stat system
STR/AGI/INT
Class - Swordsman, Rogue, Artist, Musician, Dregg, Engineer
sub class - Djinn, Knight, Samurai, Driuid, Holy, Nullifier, Theif, Hunter, Fighter, Muse, Bard, Steam-Punk, Light Mage, Dark Mage, Creator, Techsmith, Alchemist, Dosser.

