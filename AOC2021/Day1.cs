using System;
using System.IO;
using System.Linq;

namespace AOC2021
{
    public static class Day1
    {
        public static int Execute()
        {
            Console.WriteLine("Hello World!");
            var cats = Directory.GetCurrentDirectory();
            Console.WriteLine(cats);
            var meow = File.ReadAllLines("./InputFiles/day1.txt");
            Console.WriteLine(string.Join("\n", meow));

            var numbers = meow.Select(int.Parse).ToArray();

            var increases = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    increases++;
                }
            }
            Console.WriteLine($"Number of increases: {increases} out of {numbers.Length} measurements");
            return Environment.ExitCode;
        }
    }
}