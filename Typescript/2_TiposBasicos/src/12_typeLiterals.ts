let x = 10; // eslint-disable-line
x = 0b1010;
const y = 10; // quando eu declaro assim, o meu Y vira do tipo "10". Ou seja, ele é um "subtipo" de number, com valor 10 - eu não posso mais alterar pra 100, ou 20... ele é um tipo LITERAL
const a = 100; // eslint-disable-line

const pessoa = {
    nome: 'Luiz' as const,
    sobrenome: 'Miranda',
};

export function escolhaCor(cor: 'Vermelho' | 'Amarelo' | 'Azul'): string {
    return cor;
}
console.log(escolhaCor('Vermelho'), pessoa, x, y);
// SAIDA: Vermelho { nome: 'Luiz', sobrenome: 'Miranda' } 10 10 (x e y saíram 10 por que foram os primeiros valores declarados, eles NÃO podem ser alterados conforme descrito acima)
