var input = window.prompt("Input number:");
var bitPos = 3;
var mask = 1 << bitPos;

var result = (input && mask == mask) ? ('Value of bit at position 3 is: 1') : 
                                        ('Value of bit at position 3 is: 0');

document.write(result)