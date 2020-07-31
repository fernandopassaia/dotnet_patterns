"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Pessoa = void 0;
class Pessoa {
    constructor(nome, sobrenome, idade, _cpf) {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.idade = idade;
        this._cpf = _cpf;
        this.cpf = _cpf;
    }
    set cpf(cpf) {
        console.log('SETTER CHAMADO');
        this._cpf = cpf;
    }
    get cpf() {
        console.log('GETTER CHAMADO');
        return this._cpf.replace(/\D/g, '');
    }
}
exports.Pessoa = Pessoa;
const pessoa = new Pessoa('Luiz', 'Miranda', 30, '123.456.798-00');
pessoa.cpf = '123.456.798-99';
console.log(pessoa.cpf);
//# sourceMappingURL=06_GettersSetters.js.map