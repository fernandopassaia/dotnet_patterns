"use strict";
/* eslint-disable */
Object.defineProperty(exports, "__esModule", { value: true });
// Tipos básicos (aqui ocorre inferência de tipos)
var nome = 'Luiz'; // Qualquer tipo de strings: '' "" ``
var idade = 10; // 10, 1.57, -5.55, 0xf00d, 0b1010, 0o7744
var adulto = true; // true ou false
var simbolo = Symbol('qualquer-symbol'); // symbol
// let big: bigint = 10n; // bigint
// Arrays
var arrayDeNumeros = [1, 2, 3];
var arrayDeNumeros2 = [1, 2, 3];
var arrayDeStrings = ['a', 'b'];
var arrayDeStrings2 = ['a', 'b'];
// Objetos (veja que eu defino 3 propriedades, sendo adulto como opcional, depois inicializo ele já)
var pessoa = {
    idade: 30,
    nome: 'Luiz'
};
// Funções (note que :number significa que irá retornar um número)
function soma(x, y) {
    return x + y;
}
// eu consigo declarar a função definindo os tipos, depois com arrowfunction defino a função em si e o retorno
var soma2 = function (x, y) { return x + y; };
// Module mode
exports.default = 1;
console.log(pessoa);
console.log(soma(2, 2));
console.log(soma2(2, 2));
