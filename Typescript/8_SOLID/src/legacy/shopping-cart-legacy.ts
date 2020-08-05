// Nota: O Professor adota a seguinte estratégia: Ele vai criar um carrinho de compras, e programar de QUALQUER forma.
// Então essa classe não tem padrão nenhum, pattern 0. Depois ele irá REFATORAR usando todos os princípios SOLID.

type CartItem = { name: string; price: number };
type OrderStatus = 'open' | 'closed';

export class ShoppingCartLegacy {
  private readonly _items: CartItem[] = []; //ele bota uma underline só pra não fazer confusão com o (GET) items
  private _orderStatus: OrderStatus = 'open';

  addItem(item: CartItem): void {
    this._items.push(item);
  }

  removeItem(index: number): void {
    this._items.splice(index, 1); //do indice que quero, removo 1 elemento
  }

  get items(): Readonly<CartItem[]> { //retorna um array de produtos que não podem ser alterados
    return this._items;
  }

  get orderStatus(): OrderStatus {
    return this._orderStatus;
  }

  total(): number {
    return +this._items
      .reduce((total, next) => total + next.price, 0)
      .toFixed(2); //total
  }

  checkout(): void {
    if (this.isEmpty()) {
      console.log('Seu carrinho está vazio');
      return;
    }

    this._orderStatus = 'closed';
    this.sendMessage(`Seu pedido com total de ${this.total()} foi recebido.`);
    this.saveOrder();
    this.clear();
  }

  isEmpty(): boolean {
    return this._items.length === 0;
  }

  sendMessage(msg: string): void {
    console.log('Mensagem enviada:', msg);
  }

  saveOrder(): void {
    console.log('Pedido salvo com sucesso...');
  }

  clear(): void {
    console.log('Carrinho de compras foi limpo...');
    this._items.length = 0;
  }
}

// aqui ele fará alguns TESTES da classe - como ainda não criamos TESTES unitários, ele testará no console
const shoppingCart = new ShoppingCartLegacy();
shoppingCart.addItem({ name: 'Camiseta', price: 49.91 });
shoppingCart.addItem({ name: 'Caderno', price: 9.9123 });
shoppingCart.addItem({ name: 'Lápis', price: 1.59 });

console.log(shoppingCart.items);
console.log(shoppingCart.total());
console.log(shoppingCart.orderStatus);
shoppingCart.checkout();
console.log(shoppingCart.orderStatus);
