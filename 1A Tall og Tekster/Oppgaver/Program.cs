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
            // Oppgave 1 - Variabler

            string fornavn = "Jesper";

            Console.WriteLine($"Du heter {fornavn}");
            Console.WriteLine($"Han heter {fornavn}");
            Console.WriteLine($"De tror du heter {fornavn}");



            // Oppgave 1 - Tallvariabler

            int a = 7;

            Console.WriteLine(a);

            a = a + 1;
            int b = a - 2;

            Console.WriteLine(a);
            Console.WriteLine(b);



            // Oppgave 2 - Tallvariabler

            a = 7;

            Console.WriteLine(a);

            a = a - 3;
            b = a / 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
