@decorator
export class Animal {
    constructor(public nome: string, public cor: string) { }
}

//(...args: any[]) => any> quer dizer que a função recebe qualquer argumento (any[]) e retorna qualquer coisa any
function decorator<T extends new (...args: any[]) => any>(target: T): T {
    return class extends target { // estou criando uma classe e extendendo a classe que vou receber...
        cor: string;
        nome: string;

        constructor(...args: any[]) {
            console.log('Escrevendo de dentro do construtor');
            super(...args);
            this.nome = this.inverte(args[0]);
            this.cor = this.inverte(args[1]);
        }

        inverte(valor: string): string {
            return valor.split('').reverse().join('');
        }
    };
}

const animal = new Animal('Luiz', 'roxo');
console.log(animal);
