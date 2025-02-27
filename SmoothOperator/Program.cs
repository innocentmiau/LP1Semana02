using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro:");
            sbyte n = Convert.ToSByte(Console.ReadLine());
            
            Console.WriteLine($"Number: {--n}");
            Console.WriteLine($"Number: {++n}");

            bool truesteFormOfTrueing = (n == 5) ? !false : !true;
        }
    }
}
