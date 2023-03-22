// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function GetCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function SetCookie(cname, cvalue) {
    const d = new Date();
    d.setTime(d.getTime() + (7 * 24 * 60 * 60 * 1000));
    let expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function Add(id) {
    SetCookie("article" + id, GetCookie("article" + id) + 1);
    window.location.reload();
}

function Delete(id)
{
    DeleteCookie("article" + id);
    window.location.reload();
}

function Reduce(id)
{
    var quantity = GetCookie("article" + id);
    if (quantity > 1) {
        SetCookie("article" + id, quantity - 1);
    }
    else {
        DeleteCookie("article" + id);
    }
    window.location.reload();
}