using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oppgave 1

            Console.Write("Input any number: ");
            string str = Console.ReadLine();
            int num = int.Parse(str);

            if (num < 0)
            {
                Console.WriteLine("Number is smaller than 0");
            }
            else if (num > 0)
            {
                Console.WriteLine("Number is larger than 0");
            }
            else
            {
                Console.WriteLine("Number is 0");
            }


            // Oppgave 2

        }
    }
}
