//Nota: Aqui ele vai montar a função "Filter" do TypeScript/JS só que toda MANUALMENTE, na mão...
//Ou seja: Ele está "simulando" o que há por baixo dos panos do TS, só pra gente entender o uso de generics

//Nota: Na minha callback é a mesma coisa: Preciso falar que ele recebe um Genérico <U>, value também é U, e meu array também é <U>
//Ou seja: aqui também vai virar generics... eu escolhi a letra U apenas por convenção, poderia ser T também, ou mesmo um texto, qualquer coisa...
type FilterCallback<U> = (value: U, index?: number, array?: U[]) => boolean;

//meuFilter<T>: aqui ele vai inferir o tipo quando eu chamar a função - se eu mandar um array de number, ele vai entender/inferir que é um array de number
//array T[]: aqui estou falando que meu array de entrada é do MESMO tipo que o meu <T> do meuFilter - da entrada
//FilterCallBack<T>: O filterCallBack vai receber a MESMA Coisa - que irá entrar no meu método... mesmo tipo genérico...
//T[]: Mesma regra, se eu sei que minha entrada é um Array de T[], eu sei que meu RETORNO também será um array de T[]
export function meuFilter<T>(array: T[], callbackfn: FilterCallback<T>): T[] {
    const novoArray = [];

    for (let i = 0; i < array.length; i++) {
        if (callbackfn(array[i])) { //se minha função de callback retornar TRUE
            novoArray.push(array[i]); //vou adicionar o item no array de retorno
        }
    }

    return novoArray;
}

const array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 'A'];

const arrayFiltradoOriginal = array.filter((value) => value < 5); //usando o filter do TS
console.log(arrayFiltradoOriginal);

const arrayFiltrado = meuFilter(array, (value) => value < 5); //usando o meu filter
console.log(arrayFiltrado);
