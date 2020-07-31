"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Motor = exports.Carro = void 0;
class Carro {
    constructor() {
        this.motor = new Motor();
    }
    ligar() {
        this.motor.ligar();
    }
    acelerar() {
        this.motor.acelerar();
    }
    parar() {
        this.motor.parar();
    }
    desligar() {
        this.motor.desligar();
    }
}
exports.Carro = Carro;
class Motor {
    ligar() {
        console.log('Motor está ligado...');
    }
    acelerar() {
        console.log('Motor está acelerando...');
    }
    parar() {
        console.log('Motor está parado...');
    }
    desligar() {
        console.log('Motor está desligado...');
    }
}
exports.Motor = Motor;
const carro = new Carro();
carro.ligar();
carro.acelerar();
carro.parar();
carro.desligar();
//# sourceMappingURL=13_Composicao.js.map