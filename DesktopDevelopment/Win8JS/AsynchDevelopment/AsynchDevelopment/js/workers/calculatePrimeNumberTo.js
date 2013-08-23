﻿/// <reference group="Dedicated Worker" />
var isPrime = function(number) {
    for (var i = 2; i < number; i++) {
        if (number % i == 0) {
            return false;
        }
    }
    return true;
};

var calculatePrimes = function(toNumber) {
    var primesList = new Array();

    for (var ind = 1; ind < toNumber; ind++) {
        if (isPrime(ind)) {
            primesList.push(ind);
        }
    }

    return primesList;
};

onmessage = function(event) {
    var result = calculatePrimes(event.data.toNumber);

    postMessage(result);
};
