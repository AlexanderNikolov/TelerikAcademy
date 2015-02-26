/*
    1. Assign all the possible JavaScript literals to different variables.
*/

//integer base 10
var integer = 2; //2
document.write(String(integer) + "<br\>");

//integer base 8
var octal = -077; //-63
document.write(String(octal) + "<br\>");

//integer base 16
var hexdecimal = 0xF7; //247
document.write(String(hexdecimal) + "<br\>");

//char
var charSymbol = 'z';
document.write(String(charSymbol) + "<br\>");

//boolean
var booleanType = false;
document.write(String(booleanType) + "<br\>");;

var doubleNumber = 3.14;
document.write(String(doubleNumber) + "<br\>");

var text = "\"Ave Caesar, morituri te salutant!\"";
document.write(text + "<br\>");

var undefinedType;
document.write(String(typeof(undefinedType)) + "<br\>");

var nullType = null;
document.write(String(nullType) + "<br\>");

//array
var arr = ["French Roast", "Colombian", , "Kona"];
document.write(String(typeof(arr)));