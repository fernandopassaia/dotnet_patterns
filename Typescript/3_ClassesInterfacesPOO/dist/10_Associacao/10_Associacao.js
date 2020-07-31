"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.MaquinaEscrever = exports.Caneta = exports.Ferramenta = exports.Escritor = void 0;
class Escritor {
    constructor(_nome) {
        this._nome = _nome;
        this._ferramenta = null;
    }
    get nome() {
        return this._nome;
    }
    set ferramenta(ferramenta) {
        this._ferramenta = ferramenta;
    }
    get ferramenta() {
        return this._ferramenta;
    }
    escrever() {
        if (this.ferramenta === null) {
            console.log('Não posso escrever sem ferramenta...');
            return;
        }
        this.ferramenta.escrever();
    }
}
exports.Escritor = Escritor;
class Ferramenta {
    constructor(_nome) {
        this._nome = _nome;
    }
    get nome() {
        return this._nome;
    }
}
exports.Ferramenta = Ferramenta;
class Caneta extends Ferramenta {
    escrever() {
        console.log(`${this.nome} está escrevendo...`);
    }
}
exports.Caneta = Caneta;
class MaquinaEscrever extends Ferramenta {
    escrever() {
        console.log(`${this.nome} está digitando...`);
    }
}
exports.MaquinaEscrever = MaquinaEscrever;
const escritor = new Escritor('Luiz');
const caneta = new Caneta('Bic');
const maquinaEscrever = new MaquinaEscrever('Máquina');
escritor.ferramenta = caneta;
escritor.ferramenta = maquinaEscrever;
escritor.ferramenta = null;
escritor.escrever();
//# sourceMappingURL=10_Associacao.js.map