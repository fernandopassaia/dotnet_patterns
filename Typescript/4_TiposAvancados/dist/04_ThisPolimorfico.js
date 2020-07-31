"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.RequestBuilder = exports.SubCalculadora = exports.Calculadora = void 0;
class Calculadora {
    constructor(numero) {
        this.numero = numero;
    }
    add(n) {
        this.numero += n;
        return this;
    }
    sub(n) {
        this.numero -= n;
        return this;
    }
    div(n) {
        this.numero /= n;
        return this;
    }
    mul(n) {
        this.numero *= n;
        return this;
    }
}
exports.Calculadora = Calculadora;
class SubCalculadora extends Calculadora {
    pow(n) {
        this.numero **= n;
        return this;
    }
}
exports.SubCalculadora = SubCalculadora;
const calculadora = new SubCalculadora(10);
calculadora.add(5).mul(2).div(2).sub(5).pow(2);
console.log(calculadora);
class RequestBuilder {
    constructor() {
        this.method = null;
        this.url = null;
    }
    setMethod(method) {
        this.method = method;
        return this;
    }
    setUrl(url) {
        this.url = url;
        return this;
    }
    send() {
        console.log(`Enviando dados via ${this.method} para ${this.url}`);
    }
}
exports.RequestBuilder = RequestBuilder;
const request = new RequestBuilder();
request.setUrl('http://www.google.com').setMethod('post').send();
//# sourceMappingURL=04_ThisPolimorfico.js.map