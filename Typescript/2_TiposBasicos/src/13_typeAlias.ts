type Idade = number;
type Pessoa = {
    nome: string;
    idade: Idade;
    salario: number;
    corPreferida?: string;
};
type CorRGB = 'Vermelho' | 'Verde' | 'Azul'; // OR (eu posso usar o pipe | pra fazer "union" também)
type CorCMYK = 'Ciano' | 'Magenta' | 'Amarelo' | 'Preto';
type CorPreferida = CorRGB | CorCMYK; // cor preferida é um "union" de das duas cores acima

const pessoa: Pessoa = { //crio um objeto do tipo pessoa
    idade: 30,
    nome: 'Luiz',
    salario: 200_000, //O Typescript e o Python permitem usar uma underline pra separar um número, pra ficar mais fácil a leitura... o que ele irá de fato entender é 200000
};

export function setCorPreferida(pessoa: Pessoa, cor: CorPreferida): Pessoa {
    return { ...pessoa, corPreferida: cor }; // vou alterar a pessoa colocando a cor e retornando a pessoa
} // esses ... chama "spread operator" e ele faz um "shalow copy" da pessoa

console.log(setCorPreferida(pessoa, 'Azul')); //chamo o setCorPreferida e passo azul
console.log(pessoa); //imprimir
