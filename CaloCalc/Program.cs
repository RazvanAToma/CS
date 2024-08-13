using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Write the name of the item you want to add, or leave blank to calculate: ");
                string userInput = Console.ReadLine();

                if (userInput.Length != 0)
                {
                    string newDictName = userInput;
                }
                else
                {
                    Console.WriteLine("The Field was left Empty");
                    break;
                }
            }
        }
    }
}