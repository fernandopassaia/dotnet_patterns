using System;

namespace I_Wrong
{
    public class ImpressoraSimples : IImpressoraMultifuncional
    {
        public void Digitalizar(string conteudo)
        {
            throw new NotImplementedException();
        }

        public void EnviarFax(string conteudo)
        {
            throw new NotImplementedException();
        }

        public void Imprimir(string conteudo)
        {
            Console.WriteLine($"Impresso: '{conteudo}'");
        }

        public void ImprimirDuplex(string conteudo)
        {
            throw new NotImplementedException();
        }
    }
}
