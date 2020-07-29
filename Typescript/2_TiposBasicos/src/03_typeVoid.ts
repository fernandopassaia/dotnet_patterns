function semRetorno(...args: string[]): void { //aqui estou definindo uma FUNÇÃO
    console.log(args.join(' '));
}

// Nota: Um método é uma função que está dentro de um objeto ou uma classe, então nesse caso eu posso declarar um objeto pessoa
// e dentro dele ter um método exibirNome. Note que a ASSINATURA de função ou de método são basicamente iguais...
const pessoa = {
    nome: 'Luiz',
    sobrenome: 'Otávio',

    exibirNome(): void { // aqui estou definindo um MÉTODO
        console.log(this.nome + ' ' + this.sobrenome);
    },
};

semRetorno('Luiz', 'Otávio');
pessoa.exibirNome();

export { pessoa };
