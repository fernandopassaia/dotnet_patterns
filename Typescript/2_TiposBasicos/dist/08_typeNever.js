"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.criaErro = void 0;
function criaErro() {
    throw new Error('Erro qualquer'); //never quer dizer que aquela função ou método NUNCA vai retornar NADA
}
exports.criaErro = criaErro;
criaErro();
// Module mode
exports.default = 1;
