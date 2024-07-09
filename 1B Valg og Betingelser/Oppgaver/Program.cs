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

            Console.Write("Unput Any Positive Number:");
            string inputStr = Console.ReadLine();
            int inputNum = int.Parse(inputStr);

            if (inputNum >= 0 && inputNum <= 9)
            {
                Console.WriteLine($"{inputNum} is made up of only 1 digit");
            }
            else if (inputNum >= 10 && inputNum <= 99)
            {
                Console.WriteLine($"{inputNum} is made up of only 2 digits");
            }
            else if (inputNum >= 100 && inputNum <= 999)
            {
                Console.WriteLine($"{inputNum} is made up of only 3 digits");
            }
            else if (inputNum >= 1000 && inputNum <= 9999)
            {
                Console.WriteLine($"{inputNum} is made up of only 4 digits");
            }
            else if (inputNum > 9999)
            {
                Console.WriteLine($"{inputNum} is made up of 5 digits or more");
            }
            else
            {
                Console.WriteLine("Your Number is not valid...");
            }
        }
    }
}
