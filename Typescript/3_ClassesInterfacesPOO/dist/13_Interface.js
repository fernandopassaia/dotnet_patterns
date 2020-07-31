"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Pessoa = void 0;
class Pessoa {
    constructor(nome, sobrenome) {
        this.nome = nome;
        this.sobrenome = sobrenome;
    }
    nomeCompleto() {
        return this.nome + ' ' + this.sobrenome;
    }
}
exports.Pessoa = Pessoa;
const pessoaObj = {
    nomeCompleto() {
        return this.nome + ' ' + this.sobrenome;
    },
    nome: 'Luiz',
    sobrenome: 'Agora tá ok',
};
const pessoa = new Pessoa('Luiz', 'Miranda');
console.log(pessoa.nomeCompleto());
console.log(pessoaObj.nomeCompleto());
//# sourceMappingURL=13_Interface.js.map