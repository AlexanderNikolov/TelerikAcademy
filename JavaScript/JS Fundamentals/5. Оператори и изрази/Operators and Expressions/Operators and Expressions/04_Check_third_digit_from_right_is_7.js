var input = window.prompt("Input number with at least 3 digits long:");

var digitPos = 100;
var result = ((input / digitPos) >> 0) % 10 === 7 ? 'true' : 'false';

document.write(input + " " + result);