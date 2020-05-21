using System;
using System.Collections.Generic;

namespace L
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note agora que minha Lista de Figuras irá aceitar tanto objetos do tipo Retangulo, quanto objetos do tipo quadrado
            List<Figura> objetos = new List<Figura>();

            var objeto1 = new Retangulo();
            objeto1.SetAltura(4);
            objeto1.SetLargura(5);
            objetos.Add(objeto1); // adiciono um retangulo as figuras

            var objeto2 = new Quadrado();
            objeto2.setTamanho(4);
            objetos.Add(objeto2); // adiciono um quadrado as figuras

            foreach (Figura figura in objetos)
            {
                Console.WriteLine($"Area do {figura.GetType().Name} é: {figura.Area()}");
            }
            Console.ReadLine();
        }
    }
}
