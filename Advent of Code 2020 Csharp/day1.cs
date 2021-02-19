using System;
using System.IO;

namespace Advent_of_Code_2020_Csharp
{
    class day1
    {
        static void Main(string[] args)
        {
            string[] lines;
            lines = File.ReadAllLines("c:/Users/Gianni Selleslagh/source/repos/Advent of Code/Day 1/input.txt");

            bool notFound = true;

            for (int i = 0; i < lines.Length; i++)
            {
                int tempA = int.Parse(lines[i]);
                for (int j = 0; j < lines.Length; j++)
                {
                    int tempB = int.Parse(lines[j]);
                    for (int k = 0; k < lines.Length; k++)
                    {
                        int tempC = int.Parse(lines[k]);
                        if (tempA + tempB + tempC == 2020 && notFound)
                        {
                            Console.WriteLine(tempA * tempB * tempC);
                            notFound = false;
                        }
                    }

                }
            }
        }
    }
}
