using System;

namespace jajarGenjang
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 20; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
