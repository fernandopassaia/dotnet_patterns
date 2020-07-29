// Utilize any apenas em último caso
function showMessage(msg: any) {
    return msg;
}

console.log(showMessage([1, 2, 3]));
console.log(showMessage('Olá'));
console.log(showMessage(1));

// Module mode
export default 1;

// O Uso de Any é RUIM por que eu fico sem tipagem... funciona, mas não tem tipagem
