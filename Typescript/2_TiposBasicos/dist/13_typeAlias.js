"use strict";
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.setCorPreferida = void 0;
var pessoa = {
    idade: 30,
    nome: 'Luiz',
    salario: 200000,
};
function setCorPreferida(pessoa, cor) {
    return __assign(__assign({}, pessoa), { corPreferida: cor }); // vou alterar a pessoa colocando a cor e retornando a pessoa
} // esses ... chama "spread operator" e ele faz um "shalow copy" da pessoa
exports.setCorPreferida = setCorPreferida;
console.log(setCorPreferida(pessoa, 'Azul')); //chamo o setCorPreferida e passo azul
console.log(pessoa); //imprimir
