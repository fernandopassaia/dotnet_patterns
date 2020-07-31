// Agregação: Uma classe precisa de outra classe pra viver (Carrinho precisa de produtos) mas ambas podem viver separadamente.
// Aqui já é uma relação mais "grudada", onde um objeto PRECISA de outro.

export class CarrinhoDeCompras {
    private readonly produtos: Produto[] = [];

    inserirProdutos(...produtos: Produto[]): void { // com o rest-operator (...) eu posso mandar 1 produto ou vários produtos
        for (const produto of produtos) {
            this.produtos.push(produto);
        }
    }

    quantidadeProdutos(): number {
        return this.produtos.length;
    }

    valorTotal(): number {
        return this.produtos.reduce((soma, produto) => soma + produto.preco, 0);
    }
}

export class Produto {
    constructor(public nome: string, public preco: number) { }
}

const produto1 = new Produto('Camiseta', 49.9);
const produto2 = new Produto('Caneca', 1.9);
const produto3 = new Produto('Caneta', 0.9);

const carrinhoDeCompras = new CarrinhoDeCompras();
carrinhoDeCompras.inserirProdutos(produto1, produto2, produto3);
console.log(carrinhoDeCompras.valorTotal());
console.log(carrinhoDeCompras.quantidadeProdutos());
