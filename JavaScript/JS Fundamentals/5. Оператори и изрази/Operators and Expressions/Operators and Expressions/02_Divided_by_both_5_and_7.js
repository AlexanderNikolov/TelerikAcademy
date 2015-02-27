var input2 = window.prompt("Input integer number:")

var result = (input2 % 35 === 0) ? 'Number can be divided by 5 and 7' :
                                   'Number can\'t be divided by 5 and 7';

document.write(input2 + " " + result);