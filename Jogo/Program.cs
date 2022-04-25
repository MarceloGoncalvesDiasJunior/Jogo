using System;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tentativas = 0;
            int num = 0;
            Random r = new Random();
            int a = r.Next(0, 10);
            while (true)
            {
                tentativas++;



                Console.WriteLine("Advinha o número que eu pensei!");
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch { Console.WriteLine("Eu disse número."); }
                if (num < a) { Console.WriteLine("Maior..."); }
                else if (num > a) { Console.WriteLine("Menor..."); }
                if (num == a)
                {
                    Console.Write("Parábens você conseguiu");
                    Console.WriteLine("\nDepois de {0} tentativas.", tentativas);

                    break;

                }

            }
            Console.Read();

        }
    }
}
