using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oppgave 1

            double arealKvadrat(int side)
            {
                return Math.Pow(side, 2);
            }

            Console.WriteLine($"Arealet er {arealKvadrat(5)}");



            // Oppgave 2

            void arealSirkel(float radius)
            {
                double areal = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine($"Arealet av en sirkel med radius {radius} er {Math.Round(areal, 2)}");
            }

            arealSirkel(2);



            // Oppgave 3

            void byOgLand(string by, string land)
            {
                Console.WriteLine($"{by} er en by i {land}");
            }

            byOgLand("Oslo", "Norge");


            // Oppgave 4

            void minst(int a, int b)
            {
                if (a > b)
                {
                    Console.WriteLine($"{a} er storre enn {b}");
                }
                else
                {
                    Console.WriteLine($"{b} er storre enn {a}");
                }
            }

            minst(5, 10);



            // Oppgave 5

            Console.Write("Skriv inn navn:");
            string inputName = Console.ReadLine();

            void nameTag(string name)
            {
                int nameLength = name.Length;


                Console.Write("+");

                for (int i = 0; i < nameLength; i += 1)
                {
                    Console.Write("-");
                }

                Console.WriteLine("+");


                Console.Write("|");

                Console.Write(name);

                Console.WriteLine("|");


                Console.Write("+");

                for (int i = 0; i < nameLength; i += 1)
                {
                    Console.Write("-");
                }

                Console.WriteLine("+");

            }

            nameTag(inputName);
        }
    }
}
