var input = 97; //change value for test

//using Trial Division (simplest and fastest for small numbers method)
var devider = 2;
var deviderLimit = Math.sqrt(input) + 1;
var isPrime = true;

while (isPrime && (devider <= deviderLimit)) {
    if (input % devider === 0) {
        isPrime = false;
        break;
    }

    devider++;
}

var result = (isPrime) ? 'Number is prime.' : 'Number is not prime';
document.write(result);