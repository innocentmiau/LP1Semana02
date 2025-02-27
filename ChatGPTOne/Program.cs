using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Qual a sua questão? ");
                string input = Console.ReadLine().ToLower();
                
                string answer = null;
                switch (input) {
                    case "como estás?":
                        answer = "Eu estou bem, obrigado!";
                        break;
                    case "Qual é a tua linguagem favorita?":
                        answer = "Javascript";
                        break;
                    case "Qual é a última versão do Unity?":
                        answer = "Perguntas sobre versões de sistemas podem estar erradas, este IA foi treinado durante 2023 portanto apenas contenho informação até essa data. Mas a última versão do Unity até essa data foi a versão 2023.2.4f1.";
                        break;
                    case "Como programar em C#?":
                        answer = "Pergunta a outro AI, eu não percebo C#.";
                        break;
                }

                if (input.Equals("exit")) break;

                if (answer == null) {

                    Console.WriteLine("Não reconheci a questão");
                
                } else {

                    Console.WriteLine($"Resposta: {answer}");

                }

            }
        }
    }
}
