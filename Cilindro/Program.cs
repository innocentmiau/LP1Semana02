using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {

            /*
            Cria programa que:
            1 Peça ao utilizador a altura a do cilindro
            2 Peça ao utilizador o raio r do cilindro
            3 Apresenta o volume V desse cilindro
            4 Apresenta a área de superfície Sa desse cilindro
            → Usa doubles e a classe Math (π, potenciação) na resolução do problema
            → Usa tres casas decimais para representar os resultados

            V = πr^2a
            Sa = 2πr(r + a)
            */
            
            Console.WriteLine("Altura do cilindro: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Raio do cilindro: ");
            double r = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(r, 2) * a;
            Console.WriteLine($"Volume do cilindro: {volume:F3}");
            double area = 2 * Math.PI * (r * (r + a));
            Console.WriteLine($"Área da superfície do cilindro: {area:F3}");
        }
    }
}
