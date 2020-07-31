export class Pessoa {
    static idadePadrao = 0;
    static cpfPadrao = '000.000.000-00'; //MEXE SEM INSTANCIAR

    constructor(
        public nome: string,
        public sobrenome: string,
        public idade: number,
        public cpf: string,
    ) { }

    metodoNormal(): void {
        console.log(Pessoa.idadePadrao, Pessoa.cpfPadrao);
    }

    // MÉTODOS ESTÁTICOS SÃO AQUELES QUE PODEM SER ACESSADOS SEM INSTANCIAR A CLASSE
    static criaPessoa(nome: string, sobrenome: string): Pessoa {
        return new Pessoa(nome, sobrenome, Pessoa.idadePadrao, Pessoa.cpfPadrao);
    }
}

const pessoa1 = new Pessoa('Luiz', 'Miranda', 30, '123.456.798-00');
const pessoa2 = Pessoa.criaPessoa('Maria', 'Miranda');
console.log(pessoa1);
console.log(pessoa2);
pessoa1.metodoNormal();
console.log(Pessoa.idadePadrao, Pessoa.cpfPadrao);
