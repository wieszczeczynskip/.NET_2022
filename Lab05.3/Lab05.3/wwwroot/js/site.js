var n = Number(window.prompt("Podaj wielkość tabliczki, od 5 do 20", 12))

if (n < 5 || n > 20 || isNaN(n)) {
    n = 12
    window.alert("Liczba nieprawidłowa, wielkość ustalona na 12")
}

var arr = [[""]];

for (let i = 1; i < n + 1; i++) {
    arr[0][i] = (Math.floor(Math.random() * 99) + 1)
    arr[i] = []
    arr[i][0] = arr[0][i]
}

for (let i = 1; i < n + 1; i++) {
    for (let j = 1; j < n + 1; j++) {
        arr[i][j] = arr[0][j] * arr[i][0]
    }
}

const tbl = document.createElement("table");
const tblBody = document.createElement("tbody");

for (let i = 0; i < n + 1; i++) {
    const row = document.createElement("tr");
    for (let j = 0; j < n + 1; j++) {
        const cell = document.createElement("td");
        const cellText = document.createTextNode(`${arr[i][j]}`);
        if (i == 0 || j == 0) {
            cell.classList.add("tmheader");
        }
        else {
            if (arr[i][j] % 2 == 1) {
                cell.classList.add("odd");
            }
            else {
                cell.classList.add("even");
            }
        }
        cell.appendChild(cellText);
        row.appendChild(cell);
    }
    tblBody.appendChild(row);
}
tbl.appendChild(tblBody);
document.body.appendChild(tbl);
tbl.setAttribute("border", "2");

var mouseX = 0;
var mouseY = 0;
var canvases = document.querySelectorAll(".tracker");

for (let i = 0; i < canvases.length; i++) {
    startup(canvases[i]);
}

function startup(c) {
    c.onmousemove = mouseMove;
    c.addEventListener("mouseleave", (event) => {
        c.getContext("2d").clearRect(0, 0, c.width, c.height);
    });
}

function mouseMove(evt) {
    var canvas = evt.target;

    var rect = canvas.getBoundingClientRect();

    mouseX = window.event.clientX - rect.left;
    mouseY = window.event.clientY - rect.top;

    var ctx = canvas.getContext("2d");

    ctx.clearRect(0, 0, canvas.width, canvas.height);

    ctx.beginPath();
    ctx.arc(mouseX, mouseY, 40, 0, 2 * Math.PI);
    ctx.moveTo(mouseX, 0);
    ctx.lineTo(mouseX, mouseY);
    ctx.moveTo(mouseX, canvas.height);
    ctx.lineTo(mouseX, mouseY);
    ctx.moveTo(0, mouseY);
    ctx.lineTo(mouseX, mouseY);
    ctx.moveTo(canvas.width, mouseY);
    ctx.lineTo(mouseX, mouseY);
    ctx.lineWidth = 3;
    ctx.strokeStyle = "lightblue";
    ctx.stroke();
}