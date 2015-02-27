var x = 2;
var y = 3;
var radius = 5;
//using Pythagorean theorem
var result = ((x * x + y * y) <= radius * radius) ? ' is within a circle with radius ' :
                                                    ' is out of circle with radius ';

document.write("Point (" + x + "," + y + ")" + result + radius);