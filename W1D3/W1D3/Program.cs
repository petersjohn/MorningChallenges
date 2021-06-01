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
            

            foreach(char letter in name)
             {
                 if (letter != 'i')
                     Console.WriteLine("Not an i.");
                 else
                 {
                     Console.WriteLine(letter);
                 }
             }

            foreach (char letter in name)
            {
                i++;
                Console.WriteLine(i);
            }

         }

    }
}
