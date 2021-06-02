using System;

namespace W1D3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Supercalifragilisticexpialidocious";
            int i = 0;
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

            Console.ReadKey();

            foreach(char letter in name)
             {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or l.");
                }
             }
            Console.ReadKey();
            foreach (char letter in name)
            {
                i++;
                Console.WriteLine(i);
            }
            Console.ReadKey();

            



        }

    }
}
