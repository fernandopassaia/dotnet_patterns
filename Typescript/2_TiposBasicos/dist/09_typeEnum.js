"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.escolhaACor = void 0;
var Cores;
(function (Cores) {
    Cores[Cores["VERMELHO"] = 10] = "VERMELHO";
    Cores[Cores["AZUL"] = 100] = "AZUL";
    Cores[Cores["AMARELO"] = 200] = "AMARELO";
})(Cores || (Cores = {}));
(function (Cores) {
    Cores["ROXO"] = "ROXO";
    Cores[Cores["VERDE"] = 201] = "VERDE";
    Cores[Cores["ROSA"] = 202] = "ROSA";
})(Cores || (Cores = {}));
function escolhaACor(cor) {
    console.log(Cores[cor]);
}
exports.escolhaACor = escolhaACor;
escolhaACor(123456);
