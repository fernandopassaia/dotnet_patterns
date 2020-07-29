function addOrConcat(
    a: number | string | boolean, // aqui eu estou falando pro typescript que os TIPOS recebidos podem ser number, string OU boolean
    b: number | string | boolean,
): number | string { // e aqui estou dizendo que vou retornar um number OU string
    if (typeof a === 'number' && typeof b === 'number') return a + b; //e aqui eu to falando pra ele que SE FOR number, é pra somar, senão, ele vai concatenar...
    return `${a}${b}`;
}

console.log(addOrConcat(10, 20)); //20
console.log(addOrConcat('10', '20')); //1020
console.log(addOrConcat(10, '20')); //1020
console.log(addOrConcat('10', 20)); //1020
console.log(addOrConcat(true, true)); //truetrue

// Module mode
export default 1;
