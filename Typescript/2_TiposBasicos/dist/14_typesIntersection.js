"use strict";
// Nota: Intersection é similar ao Alias (pipe - | ) só que ao invés de OU ou servir pra fazer UNION de vários tipos,
// no caso do intersection & ele junta campos em um outro objeto - veja que PESSOA é a união de temnome, temsobrenome e temidade! =)
Object.defineProperty(exports, "__esModule", { value: true });
exports.pessoa = void 0;
var pessoa = {
    nome: 'Luiz',
    sobrenome: 'Miranda',
    idade: 30,
};
exports.pessoa = pessoa;
console.log(pessoa);
