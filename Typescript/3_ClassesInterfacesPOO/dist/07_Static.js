"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Pessoa = void 0;
class Pessoa {
    constructor(nome, sobrenome, idade, cpf) {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.idade = idade;
        this.cpf = cpf;
    }
    metodoNormal() {
        console.log(Pessoa.idadePadrao, Pessoa.cpfPadrao);
    }
    static criaPessoa(nome, sobrenome) {
        return new Pessoa(nome, sobrenome, Pessoa.idadePadrao, Pessoa.cpfPadrao);
    }
}
exports.Pessoa = Pessoa;
Pessoa.idadePadrao = 0;
Pessoa.cpfPadrao = '000.000.000-00';
const pessoa1 = new Pessoa('Luiz', 'Miranda', 30, '123.456.798-00');
const pessoa2 = Pessoa.criaPessoa('Maria', 'Miranda');
console.log(pessoa1);
console.log(pessoa2);
pessoa1.metodoNormal();
console.log(Pessoa.idadePadrao, Pessoa.cpfPadrao);
//# sourceMappingURL=07_Static.js.map