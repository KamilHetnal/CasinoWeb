
document.addEventListener("DOMContentLoaded", function () {
    var changeImage = document.querySelectorAll("#block")
    for (var i = 0; i < changeImage.length; i++) {
        var td = changeImage[i];
        var value = td.innerText;
        var img = document.createElement("img");
        img.src = "images/heroes0" + value + ".jpg";
        td.innerHTML = img.outerHTML;
    }
})

window.onload = function ()
{
    var bet = document.getElementById("bet").value;
    var I2 = document.getElementById("I2");
    var I3 = document.getElementById("I3");
    var I4 = document.getElementById("I4");
    var I5 = document.getElementById("I5");
    var II2 = document.getElementById("II2");
    var II3 = document.getElementById("II3");
    var II4 = document.getElementById("II4");
    var II5 = document.getElementById("II5");
    var III2 = document.getElementById("III2");
    var III3 = document.getElementById("III3");
    var III4 = document.getElementById("III4");
    var III5 = document.getElementById("III5");

    I2.innerHTML = bet * 5;
    I3.innerHTML = bet * 20;
    I4.innerHTML = bet * 100;
    I5.innerHTML = bet * 500;
    II2.innerHTML = bet * 5;
    II3.innerHTML = bet * 20;
    II4.innerHTML = bet * 100;
    II5.innerHTML = bet * 500;
    III2.innerHTML = bet * 5;
    III3.innerHTML = bet * 20;
    III4.innerHTML = bet * 100;
    III5.innerHTML = bet * 500;
}