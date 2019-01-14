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

const onClickHandler = () => {
    var bet = document.getElementById("bet").value;
    var win2 = '<b>' + bet * 5 + '</b>'
    var win3 = '<b>' + bet * 20 + '</b>'
    var win4 = '<b>' + bet * 100 + '</b>'
    var win5 = '<b>' + bet * 500 + '</b>'
    document.getElementById("I2").innerHTML = win2;
    document.getElementById("II2").innerHTML = win2;
    document.getElementById("III2").innerHTML = win2;
    document.getElementById("I3").innerHTML = win3;
    document.getElementById("II3").innerHTML = win3;
    document.getElementById("III3").innerHTML = win3;
    document.getElementById("I4").innerHTML = win4;
    document.getElementById("II4").innerHTML = win4;
    document.getElementById("III4").innerHTML = win4;
    document.getElementById("I5").innerHTML = win5;
    document.getElementById("II5").innerHTML = win5;
    document.getElementById("III5").innerHTML = win5;
}

document.addEventListener("DOMContentLoaded", onClickHandler);
document.getElementById("bet").addEventListener('click', onClickHandler);

function removeClass() {
    tab1.classList.remove("tab1");
    tab2.classList.remove("tab2");
    tab3.classList.remove("tab3");
}

function showOneLine() {
    var line = document.getElementById("lines").value;
    if (line == 1) {
        var tab2 = document.getElementById("tab2");
        setInterval(removeClass, 1000);
        tab2.classList.add("tab2");
    }
}

function showThreelines() {
    var line = document.getElementById("lines").value;
    if (line == 3) {
        var tab1 = document.getElementById("tab1");
        var tab2 = document.getElementById("tab2");
        var tab3 = document.getElementById("tab3");
        setInterval(removeClass, 1000);
        tab1.classList.add("tab1");
        tab2.classList.add("tab2");
        tab3.classList.add("tab3");
    }
}

document.getElementById("lines").addEventListener('click', showOneLine);
document.getElementById("lines").addEventListener('click', showThreelines);