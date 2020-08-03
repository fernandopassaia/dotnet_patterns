type Veiculo = {
  marca: string;
  ano: number;
};

type Car = {
  brand: Veiculo['marca']; //aqui eu estou ESPELHANDO minha marca...
  year: Veiculo['ano']; //ou seja, se eu usar CAR em outro lugar, vou espelhar no veículo
  name: string;
};

const carro: Car = {
  brand: 'Ford',
  year: 2020,
  name: 'Nome',
};

console.log(carro);
