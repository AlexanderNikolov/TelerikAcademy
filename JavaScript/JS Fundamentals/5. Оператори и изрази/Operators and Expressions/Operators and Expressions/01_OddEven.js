var input = window.prompt("Input random integer:");

if (input % 2 == 0) {
    document.write(String(input) + " Inputed number is even");
} else {
    document.write(String(input) + " Inputed number is odd");
}