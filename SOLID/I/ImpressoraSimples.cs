using System;

namespace I
{
    public class ImpressoraSimples : IImpressora
    {
        public void Imprimir(string conteudo)
        {
            Console.WriteLine($"Impresso: '{conteudo}'");
        }
    }
}
