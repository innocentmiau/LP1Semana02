using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro-não negativo: ");
            byte n = byte.Parse(Console.ReadLine());
            
            /*
            → Divisão por 2
            → Shift left por 3
            → XOR com 6
            → Se é maior que 10
            */
            byte division = (byte)(n/2);
            byte shift_left = (byte)(n<<3);
            byte xor = (byte)(n^6);
            bool greater_10 = n>10;
            Console.WriteLine(division);
            Console.WriteLine(shift_left);
            Console.WriteLine(xor);
            Console.WriteLine(greater_10);
        }
    }
}
