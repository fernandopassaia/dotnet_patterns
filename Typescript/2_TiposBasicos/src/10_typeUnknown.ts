let x: unknown;

x = 100;
x = 'Luiz';
x = 900;
x = 10;
const y = 800;

if (typeof x === 'number') console.log(x + y);

// Module mode
export default 1; //O Unknown funciona como um ANY só que mais seguro... posso comparar e ver qual é o tipo