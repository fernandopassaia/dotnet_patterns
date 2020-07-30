"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.pessoa = void 0;
function semRetorno() {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    console.log(args.join(' '));
}
// Nota: Um método é uma função que está dentro de um objeto ou uma classe, então nesse caso eu posso declarar um objeto pessoa
// e dentro dele ter um método exibirNome. Note que a ASSINATURA de função ou de método são basicamente iguais...
var pessoa = {
    nome: 'Luiz',
    sobrenome: 'Otávio',
    exibirNome: function () {
        console.log(this.nome + ' ' + this.sobrenome);
    },
};
exports.pessoa = pessoa;
semRetorno('Luiz', 'Otávio');
pessoa.exibirNome();
