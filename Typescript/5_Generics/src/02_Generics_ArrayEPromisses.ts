type MeuTipo = number;

//aqui fica claro que o array também é um generic, visto que ele PRECISA de um tipo Array<Type> pra ser definido, você PRECISA passar para o Array qual é o tipo dele.
//Note que se você clicar com o botão segurando CTRL em cima de array ele vai te MSOTRAR o código e a interface dele (similar ao GoToDefinition no C#).
const arrayNumeros: Array<number> = [1, 2, 3, 4, 5, 6];
console.log(arrayNumeros);

async function promiseAsync() {
    return 1;
}

// Nota: Veja que minha promisse retorna MeuTipo (que nesse caso é number, só por teste) e também um number
export function minhaPromise(): Promise<MeuTipo | number> {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(1);
        }, 1000);
    });
}

promiseAsync().then((resultado) => console.log(resultado + 1));
minhaPromise().then((resultado) => console.log(resultado + 1));
