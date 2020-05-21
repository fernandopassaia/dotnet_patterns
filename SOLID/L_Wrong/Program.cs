
using System;
using System.Collections.Generic;

namespace L_Wrong
{
    // This principle I'm gonna write in my native-language (Portuguese) because will be better to understand myself once i need to.
    // Regra do LSP: Se 'S' é um subtipo de 'T', então objetos do tipo 'T' podem ser substituídos por objetos do tipo 'S' sem que
    // essa substituição gere efeitos colaterais na nossa aplicação. Para essa regra usaremos o exemplo clássico de Barbara Liskov:
    // O Quadrado e Retângulo. Só lembrando: Um retângulo é um quadrado, porém os lados (altura e largura) não são iguais.

    // Uma solução ERRADA para esse problema, seria quadrado herdar de retângulo (herdando altura e largura), e então eu tentar dar override
    // nos métodos de SetAltura e SetLargura, forçando a classe quadrado a sempre receber paramêtros iguais (5 x 5). Ou Re-escrever (override)
    // o método de cálculo para que a classe de Quadrado calcule corretamente. Porém seriam soluções completamente erradas e o cálculo daria
    // errado, o código ficaria gambiarrado. Na Solução para o L, implementaremos uma classe pai (Figura) e baseado nela Retângulo e Quadrado.

    class Program
    {
        static void Main()
        {
            List<Retangulo> objetos = new List<Retangulo>();

            var objeto1 = new Retangulo();
            objeto1.SetAltura(4);
            objeto1.SetLargura(5);

            objetos.Add(objeto1);

            foreach(Retangulo figura in objetos)
            {
                Console.WriteLine($"Area do {figura.GetType().Name} é: {figura.Area()}");
            }
            Console.ReadLine();
        }
    }
}
