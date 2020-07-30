"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function addOrConcat(a, // aqui eu estou falando pro typescript que os TIPOS recebidos podem ser number, string OU boolean
b) {
    if (typeof a === 'number' && typeof b === 'number')
        return a + b; //e aqui eu to falando pra ele que SE FOR number, é pra somar, senão, ele vai concatenar...
    return "" + a + b;
}
console.log(addOrConcat(10, 20)); //20
console.log(addOrConcat('10', '20')); //1020
console.log(addOrConcat(10, '20')); //1020
console.log(addOrConcat('10', 20)); //1020
console.log(addOrConcat(true, true)); //truetrue
// Module mode
exports.default = 1;
