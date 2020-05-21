

namespace L_Wrong
{
    public class Retangulo
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

        public double Area()
        {
            return _largura * _altura;
        }
    }
}
