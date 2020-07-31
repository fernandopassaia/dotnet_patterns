"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Cliente = exports.Aluno = exports.Pessoa = void 0;
class Pessoa {
    constructor(nome, sobrenome, idade, cpf) {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.idade = idade;
        this.cpf = cpf;
    }
    getIdade() {
        return this.idade;
    }
    getCpf() {
        return this.cpf;
    }
    getNomeCompleto() {
        return this.nome + ' ' + this.sobrenome;
    }
}
exports.Pessoa = Pessoa;
class Aluno extends Pessoa {
    constructor(nome, sobrenome, idade, cpf, sala) {
        super(nome, sobrenome, idade, cpf);
        this.sala = sala;
    }
    getNomeCompleto() {
        console.log('FAZENDO ALGO ANTES');
        const result = super.getNomeCompleto();
        return result + ' HEYYYYYYYY!!';
    }
}
exports.Aluno = Aluno;
class Cliente extends Pessoa {
    getNomeCompleto() {
        return 'Isso vem do cliente: ' + this.nome + ' ' + this.sobrenome;
    }
}
exports.Cliente = Cliente;
const pessoa = new Pessoa('Luiz', 'Miranda', 30, '000.000.000-00');
const aluno = new Aluno('Luiz', 'Miranda', 30, '000.000.000-00', '0001');
const cliente = new Cliente('Luiz', 'Miranda', 30, '000.000.000-00');
console.log(pessoa.getNomeCompleto());
console.log(aluno.getNomeCompleto());
console.log(cliente.getNomeCompleto());
console.log(aluno);
//# sourceMappingURL=04_SuperClass.js.map