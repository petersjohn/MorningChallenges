using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D3c2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Supercalifragilisticexpialidocious";
            int i = 0;
            string notAnI = "Not an i or l.";
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

            Console.ReadKey();

            foreach (char letter in name)
            {
                if (letter == 'i')
                    Console.WriteLine(letter);
                else if (char.ToLower(letter) == 'l')
                    Console.WriteLine("L");
                else
                Console.WriteLine(notAnI);
                
            }
            Console.ReadKey();
            Console.WriteLine(name.Length);
            Console.ReadKey();
        }
    }
}
