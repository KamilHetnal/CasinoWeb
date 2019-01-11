
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
    let bet = document.getElementById("bet").value;
    let win2 = '<b>' + bet * 5 + '</b>'
    let win3 = '<b>' + bet * 20 + '</b>'
    let win4 = '<b>' + bet * 100 + '</b>'
    let win5 = '<b>' + bet * 500 + '</b>'
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