using System;

namespace I
{
    class Program
    {
        // ICP: Classes não devem ser forçadas a depender de métodos que elas não utilizadas. Ou seja: É melhor termos várias
        // interfaces curtas do que poucas interfaces longas, também conhecidas como interfaces monolíticas. Ou seja: Se você
        // quer usar uma banana, não faz sentido que você tenha que lidar com o macaco, com a árvore, o bananeiro.

        // Note que aqui eu criei várias interfaces especializadas para resolver o lance das impressoras descritas no I_Wrong
        static void Main()
        {
            //se trocar pra impressora comum quebra por não implementar digitalizar, duplex, fax
            var impressoraHp = new ImpressoraMultifuncional();
            impressoraHp.Imprimir("Olá pessoal!");
            impressoraHp.Digitalizar("Comprovante de endereço");
            impressoraHp.ImprimirDuplex("Imprimir em ambos lados...");
            impressoraHp.EnviarFax("Favor, enviarf por e-mail da próxima vez...");

            var impressora40Colunas = new ImpressoraSimples();
            impressora40Colunas.Imprimir("Impressora simples permite apenas imprimir...");

            Console.ReadLine();
        }
    }
}
