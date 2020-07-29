export function criaErro(): never {
    throw new Error('Erro qualquer'); //never quer dizer que aquela função ou método NUNCA vai retornar NADA
}

criaErro();

// Module mode
export default 1;
