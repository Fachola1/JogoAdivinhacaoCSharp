using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhacaoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("JOGO DE ADIVINHAÇÃO!");

            Random numeroAleatorio = new Random();

            int numeroTentativas = 2;
            int numeroComputador = numeroAleatorio.Next(1, 100);

            Console.WriteLine("Adivinhe o número entre 1 e 100 em que o computador escolheu!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Número de tentativas: {numeroTentativas}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o primeiro número: ");

            for (int i = 0; i < 2; i++)
            {

                int numeroUsuario = Convert.ToInt32(Console.ReadLine());

                if (numeroUsuario == numeroComputador)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    break;
                }

                if (numeroUsuario > numeroComputador)
                {
                    Console.WriteLine("O número que você digitou é maior a que o computador escolheu!");
                    numeroTentativas--;
                }

                if (numeroUsuario < numeroComputador)
                {
                    Console.WriteLine("O número que você digitou é menor que o computador escolheu!");
                    numeroTentativas--;
                }

                if (numeroTentativas == 0)
                {
                    Console.WriteLine("Tentativas esgotadas.");
                    break;
                }

                Console.WriteLine("Tente novamente!");

            }

            Console.WriteLine($"O número que o computador pensou foi: {numeroComputador}");

            Console.ReadLine();
        }
    }
}
