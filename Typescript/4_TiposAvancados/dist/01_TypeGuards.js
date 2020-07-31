"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Aluno = exports.add = void 0;
function add(a, b) {
    return typeof a === 'number' && typeof b === 'number' ? a + b : `${a}${b}`;
}
exports.add = add;
console.log(add(1, 5));
console.log(add('a', 'b'));
class Aluno {
    constructor(nome) {
        this.nome = nome;
        this.tipo = 'pessoa';
    }
}
exports.Aluno = Aluno;
function mostraNome(obj) {
    switch (obj.tipo) {
        case 'pessoa':
            console.log(obj.nome);
            return;
        case 'animal':
            console.log('Isso é um animal', obj.cor);
            return;
    }
}
//# sourceMappingURL=01_TypeGuards.js.map