type TipoNome = {
    nome: string;
};

type TipoSobrenome = {
    sobrenome: string;
};

type TipoNomeCompleto = {
    nomeCompleto: () => string;
};


// aqui nós temos um CONTRATO para que a classe abstrata implemente as coisas que recebeu (nota: muito similar ao Interface)
export class Pessoa implements TipoNome, TipoSobrenome, TipoNomeCompleto {
    constructor(public nome: string, public sobrenome: string) { }

    nomeCompleto(): string {
        return this.nome + ' ' + this.sobrenome;
    }
}

const pessoa = new Pessoa('Luiz', 'Miranda');
console.log(pessoa.nomeCompleto());
