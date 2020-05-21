using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Wrong
{
    class Program
    {
        // Interface Segregation Principle:
        // ISP: Classes não devem ser forçadas a depender de métodos que elas não utilizadas. Ou seja: É melhor termos várias
        // interfaces curtas do que poucas interfaces longas, também conhecidas como interfaces monolíticas. Ou seja: Se você
        // quer usar uma banana, não faz sentido que você tenha que lidar com o macaco, com a árvore, o bananeiro.

        // No exemplo: Temos uma Interface chamada "IImpressoraMultifuncional". Impressora Multifuncional tem contratos para
        // implementar métodos de Imprimir, Digitalizar, ImprimirDuplex (dois lados) e Enviar Fax. Como é de fato. Porém, se eu
        // adquirir outro equipamento, como uma impressora comum, ou 40 colunas, e herdar dessa impressora: Terei 3 métodos não
        // implementados, uma vez que elas não enviam Fax, nem Digitalizam, nem imprimem duplex. Ou seja, é melhor ter interfaces
        // menores e mais especializadas, do que uma grande interface gigantesca. Ou seja:

        // É necessário quebrar nossa interface em interfaces MENORES e mais especializadas, e ai sim terei uma boa implementação.
        // Note que abaixo se eu trocar a minha ImpressoraMultifuncional pela ImpressoraSimples, terei o aplicativo quebrado uma vez
        // que minha classe de impressora simples não implementa Envio de Fax, Digitalização e etc.
        static void Main()
        {
            //se trocar pra impressora comum quebra por não implementar digitalizar, duplex, fax
            IImpressoraMultifuncional impressoraHp = new ImpressoraMultifuncional();
            impressoraHp.Imprimir("Olá pessoal!");
            impressoraHp.Digitalizar("Comprovante de endereço");
            impressoraHp.ImprimirDuplex("Imprimir em ambos lados...");
            impressoraHp.EnviarFax("Favor, enviarf por e-mail da próxima vez...");

            Console.ReadLine();
        }
    }
}
