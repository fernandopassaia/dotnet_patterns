
using System;

namespace L
{
    public class Quadrado : Figura
    {
        private double _tamanho; //veja que quadrado não contém Altura e Largura, visto que os lados são iguais        

        public void setTamanho(double tamanho)
        {
            _tamanho = tamanho;
        }

        public override double Area()
        {
            return Math.Pow(_tamanho, 2); //tamanho elevado ao quadrado
        }
    }
}
