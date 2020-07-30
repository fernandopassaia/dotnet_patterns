"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
// Utilize any apenas em último caso
function showMessage(msg) {
    return msg;
}
console.log(showMessage([1, 2, 3]));
console.log(showMessage('Olá'));
console.log(showMessage(1));
// Module mode
exports.default = 1;
// O Uso de Any é RUIM por que eu fico sem tipagem... funciona, mas não tem tipagem
