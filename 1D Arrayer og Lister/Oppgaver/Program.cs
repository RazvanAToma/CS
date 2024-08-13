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
            /* Arrays */

            void arrays()
            {
                //  Oppgave 1

                int[] enTilFem = new int[5];

                for (int i = 0; i < 5; i += 1)
                {
                    enTilFem[i] = i + 1;
                }

                foreach (int num in enTilFem)
                {
                    Console.WriteLine(num);
                }



                // Oppgave 2

                int[] enTilFemti = new int[50];

                for (int i = 0; i < 50; i += 1)
                {
                    enTilFemti[i] = i + 1;
                }

                foreach (int num in enTilFemti)
                {
                    Console.WriteLine(num);
                }



                // Oppgave 3

                int[] firstHundredOdd = new int[100];

                int curNum = 1;

                for (int i = 0; i < 100; i += 1)
                {
                    firstHundredOdd[i] = curNum;

                    curNum += 2;
                }

                foreach (int num in firstHundredOdd)
                {
                    Console.WriteLine(num);
                }



                // Oppgave 4

                double[] firstTwentySquared = new double[20];

                for (int i = 0; i < 20; i += 1)
                {
                    firstTwentySquared[i] = Math.Pow(i, 2);
                }

                foreach (double num in firstTwentySquared)
                {
                    Console.WriteLine(num);
                }



                // Oppgave 5

                double[] firstFifteenCubed = new double[15];

                for (int i = 0; i < 15; i += 1)
                {
                    firstFifteenCubed[i] = Math.Pow(i, 3);
                }

                foreach (double num in firstFifteenCubed)
                {
                    Console.WriteLine(num);
                }



                // Oppgave 6

                string[] fiveReadLineWords = new string[5];

                for (int i = 0; i < fiveReadLineWords.Length; i += 1)
                {
                    Console.Write($"Word {i + 1}:");
                    fiveReadLineWords[i] = Console.ReadLine();
                }

                foreach (string word in fiveReadLineWords)
                {
                    Console.Write($"{word} ");
                }

                Console.WriteLine();



                // Oppgave 7

                int[] fiftyRandomInts = new int[50];

                Random rnd = new Random();

                for (int i = 0; i < fiftyRandomInts.Length; i += 1)
                {
                    fiftyRandomInts[i] = rnd.Next();
                }

                foreach (int num in fiftyRandomInts)
                {
                    Console.WriteLine(num);
                }



                // Oppgave 8

                double getAvg(int[] ints)
                {
                    int sum = 0;

                    foreach (int num in ints)
                    {
                        sum += num;
                    }

                    return sum / ints.Length;
                }

                Console.WriteLine(getAvg(enTilFem));



                // Oppgave 9

                int[] testArray = new int[5];

                testArray[0] = 512;
                testArray[1] = 1135;
                testArray[2] = 65245;
                testArray[3] = 234;
                testArray[4] = 736;

                int[] sort(int[] array)
                {
                    return array.OrderBy(x => x).ToArray();
                }

                foreach (int num in sort(testArray))
                {
                    Console.WriteLine(num);
                }



                // Oppgave 11

                int getSmallest(int[] array)
                {
                    return array.Min();
                }

                Console.WriteLine(getSmallest(testArray));



                // Oppgave 12

                int getBiggest(int[] array)
                {
                    return array.Max();
                }

                Console.WriteLine(getBiggest(testArray));
            }

            // arrays();

            
            /* Lists */

            void lists()
            {
                // Oppgave 1

                List<int> enTilFem = new List<int>();

                for (int i = 0; i < 5; i += 1)
                {
                    enTilFem.Add(i + 1);
                }

                foreach (int num in enTilFem)
                {
                    Console.WriteLine(num);
                }


                
                // Oppgave 2


            }

            lists();
        }
    }
}