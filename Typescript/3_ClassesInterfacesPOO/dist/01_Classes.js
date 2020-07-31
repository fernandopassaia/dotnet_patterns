"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Colaborador = exports.Empresa = void 0;
var Empresa = /** @class */ (function () {
    function Empresa(nome, cnpj) {
        this.colaboradores = [];
        this.nome = nome;
        this.cnpj = cnpj;
    }
    Empresa.prototype.adicionaColaborador = function (colaborador) {
        this.colaboradores.push(colaborador);
    };
    Empresa.prototype.mostrarColaboradores = function () {
        for (var _i = 0, _a = this.colaboradores; _i < _a.length; _i++) {
            var colaborador = _a[_i];
            console.log(colaborador);
        }
    };
    return Empresa;
}());
exports.Empresa = Empresa;
var Colaborador = /** @class */ (function () {
    function Colaborador(nome, sobrenome) {
        this.nome = nome;
        this.sobrenome = sobrenome;
    }
    return Colaborador;
}());
exports.Colaborador = Colaborador;
var empresa1 = new Empresa('Udemy', '11.111.111/0001-11');
var colaborador1 = new Colaborador('Luiz', 'Otávio');
var colaborador2 = new Colaborador('Maria', 'Miranda');
var colaborador3 = new Colaborador('João', 'Vieira');
empresa1.adicionaColaborador(colaborador1);
empresa1.adicionaColaborador(colaborador2);
empresa1.adicionaColaborador(colaborador3);
console.log(empresa1);
empresa1.mostrarColaboradores();
