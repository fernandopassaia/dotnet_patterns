

namespace L
{
    public class Retangulo : Figura
    {
        private double _altura;
        private double _largura;

        public void SetAltura(double altura)
        {
            _altura = altura;
        }

        public void SetLargura(double largura)
        {
            _largura = largura;
        }

        public override double Area() //o método área sobreescreve da classe pai Figura
        {
            return _largura * _altura;
        }
    }
}
