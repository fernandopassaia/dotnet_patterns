// Array<T> - T[]
export function multiplicaArgs(...args: Array<number>): number {
    return args.reduce((ac, valor) => ac * valor, 1); //reduce vai somar e imprimir 6
}

export function concatenaString(...args: string[]): string {
    return args.reduce((ac, valor) => ac + valor); //abc (vai concatenar)
}

export function toUpperCase(...args: string[]): string[] {
    return args.map((valor) => valor.toUpperCase()); // ['A', 'B', 'C']
}

const result = multiplicaArgs(1, 2, 3);
const concatenacao = concatenaString('a', 'b', 'c');
const upper = toUpperCase('a', 'b', 'c');

console.log(result);
console.log(concatenacao);
console.log(upper);
