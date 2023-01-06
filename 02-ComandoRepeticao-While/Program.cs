using System.ComponentModel.DataAnnotations;

namespace _02_ComandoRepeticao_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10) {
                Console.WriteLine($"Contando: {i}");
                i++;
            }
            Console.WriteLine("-------------------");
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($"Contando: {j}");
            }
            Console.WriteLine("-------------------");
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($"5 X {j} = {5*j}");
            }
        }
    }
}