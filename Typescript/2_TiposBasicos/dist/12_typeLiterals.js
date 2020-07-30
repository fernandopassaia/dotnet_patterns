"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.escolhaCor = void 0;
var x = 10; // eslint-disable-line
x = 10;
var y = 10; // quando eu declaro assim, o meu Y vira do tipo "10". Ou seja, ele é um "subtipo" de number, com valor 10 - eu não posso mais alterar pra 100, ou 20... ele é um tipo LITERAL
var a = 100; // eslint-disable-line
var pessoa = {
    nome: 'Luiz',
    sobrenome: 'Miranda',
};
function escolhaCor(cor) {
    return cor;
}
exports.escolhaCor = escolhaCor;
console.log(escolhaCor('Vermelho'), pessoa, x, y);
// SAIDA: Vermelho { nome: 'Luiz', sobrenome: 'Miranda' } 10 10 (x e y saíram 10 por que foram os primeiros valores declarados, eles NÃO podem ser alterados conforme descrito acima)
