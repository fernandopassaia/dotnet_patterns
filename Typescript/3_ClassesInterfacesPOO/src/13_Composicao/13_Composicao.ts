// Composição: Nesse caso um objeto TEM outro objeto, o CARRO possui um MOTOR. O Motor é parte INTEGRAL do motor, o carro é o motor.
// Outro Exemplo: Ser Humano e Coração. Se você tirar o Coração do ser humano ele MRORE. Não tem como existir um ser-humano vivo sem coração.
// Essa relação é similar a Associação, mas nesse caso ela é MUITO MAIS FORTE.

export class Carro {
    private readonly motor = new Motor();

    ligar(): void {
        this.motor.ligar();
    }

    acelerar(): void {
        this.motor.acelerar();
    }

    parar(): void {
        this.motor.parar();
    }

    desligar(): void {
        this.motor.desligar();
    }
}

export class Motor {
    ligar(): void {
        console.log('Motor está ligado...');
    }

    acelerar(): void {
        console.log('Motor está acelerando...');
    }

    parar(): void {
        console.log('Motor está parado...');
    }

    desligar(): void {
        console.log('Motor está desligado...');
    }
}

const carro = new Carro();

carro.ligar();
carro.acelerar();
carro.parar();
carro.desligar();
