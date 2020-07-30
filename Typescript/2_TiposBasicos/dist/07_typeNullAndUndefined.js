"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.squareOf = exports.createPerson = void 0;
var x;
if (typeof x === 'undefined')
    x = 20;
console.log(x * 2);
function createPerson(firstName, lastName) {
    return {
        firstName: firstName,
        lastName: lastName,
    };
}
exports.createPerson = createPerson;
function squareOf(x) {
    if (typeof x === 'number')
        return x * x;
    return null;
}
exports.squareOf = squareOf;
var squareOfTwoString = squareOf('2');
if (squareOfTwoString === null) {
    console.log('Conta inválida');
}
else {
    console.log(squareOfTwoString * 100);
}
