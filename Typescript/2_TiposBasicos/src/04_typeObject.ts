const objetoA: {
    readonly chaveA: string;
    chaveB: string;
    chaveC?: string;
    [key: string]: unknown; //aqui eu posso definir que eu terei uma chave do tipo string, mas que não sei o nome...
} = {
    chaveA: 'Valor A',
    chaveB: 'Valor B',
};

objetoA.chaveB = 'Outro valor';
objetoA.chaveC = 'Novo valor';
objetoA.chaveD = 'Nova chave'; //aqui eu dei o nome pra ela de chaveD

console.log(objetoA);

// Module mode
export default 1;
