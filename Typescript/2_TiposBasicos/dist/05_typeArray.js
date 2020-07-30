"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.toUpperCase = exports.concatenaString = exports.multiplicaArgs = void 0;
// Array<T> - T[]
function multiplicaArgs() {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    return args.reduce(function (ac, valor) { return ac * valor; }, 1); //reduce vai somar e imprimir 6
}
exports.multiplicaArgs = multiplicaArgs;
function concatenaString() {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    return args.reduce(function (ac, valor) { return ac + valor; }); //abc (vai concatenar)
}
exports.concatenaString = concatenaString;
function toUpperCase() {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    return args.map(function (valor) { return valor.toUpperCase(); }); // ['A', 'B', 'C']
}
exports.toUpperCase = toUpperCase;
var result = multiplicaArgs(1, 2, 3);
var concatenacao = concatenaString('a', 'b', 'c');
var upper = toUpperCase('a', 'b', 'c');
console.log(result);
console.log(concatenacao);
console.log(upper);
