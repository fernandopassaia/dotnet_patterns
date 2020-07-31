// NOTA: A Classe 10 já estava escrita com inversão de dependência. Note que o Escritor depende de uma FERRAMENTA,
// Eu poderia fazer ele depender direto da Caneta ou da Máquina de Escrever. Porém nesse caso ele necessita da classe
// abstrata FERRAMENTA. Ambos, Caneta e MaquinaDeEscrever são extensões e implementam Ferramenta, logo, podem ser usadas.

export class Escritor {
    private _ferramenta: Ferramenta | null = null;

    constructor(private _nome: string) { }

    get nome(): string {
        return this._nome;
    }

    set ferramenta(ferramenta: Ferramenta | null) {
        this._ferramenta = ferramenta;
    }

    get ferramenta(): Ferramenta | null {
        return this._ferramenta;
    }

    escrever(): void {
        if (this.ferramenta === null) {
            console.log('Não posso escrever sem ferramenta...');
            return;
        }
        this.ferramenta.escrever();
    }
}

export abstract class Ferramenta {
    constructor(private _nome: string) { }
    abstract escrever(): void;

    get nome(): string {
        return this._nome;
    }
}

export class Caneta extends Ferramenta {
    escrever(): void {
        console.log(`${this.nome} está escrevendo...`);
    }
}

export class MaquinaEscrever extends Ferramenta {
    escrever(): void {
        console.log(`${this.nome} está digitando...`);
    }
}

const escritor = new Escritor('Luiz');
const caneta = new Caneta('Bic');
const maquinaEscrever = new MaquinaEscrever('Máquina');

// console.log(escritor.nome);
// console.log(caneta.nome);
// console.log(maquinaEscrever.nome);

escritor.ferramenta = caneta;
escritor.ferramenta = maquinaEscrever;
escritor.ferramenta = null;
escritor.escrever();
