"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Produto = exports.CarrinhoDeCompras = void 0;
class CarrinhoDeCompras {
    constructor() {
        this.produtos = [];
    }
    inserirProdutos(...produtos) {
        for (const produto of produtos) {
            this.produtos.push(produto);
        }
    }
    quantidadeProdutos() {
        return this.produtos.length;
    }
    valorTotal() {
        return this.produtos.reduce((soma, produto) => soma + produto.preco, 0);
    }
}
exports.CarrinhoDeCompras = CarrinhoDeCompras;
class Produto {
    constructor(nome, preco) {
        this.nome = nome;
        this.preco = preco;
    }
}
exports.Produto = Produto;
const produto1 = new Produto('Camiseta', 49.9);
const produto2 = new Produto('Caneca', 1.9);
const produto3 = new Produto('Caneta', 0.9);
const carrinhoDeCompras = new CarrinhoDeCompras();
carrinhoDeCompras.inserirProdutos(produto1, produto2, produto3);
console.log(carrinhoDeCompras.valorTotal());
console.log(carrinhoDeCompras.quantidadeProdutos());
//# sourceMappingURL=12_Agregacao.js.map