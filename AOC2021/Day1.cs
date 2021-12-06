using System;
using System.IO;
using System.Linq;

namespace AOC2021
{
    public static class Day1
    {
        public static int Execute()
        {
            var cats = Directory.GetCurrentDirectory();
            var meow = File.ReadAllLines("./InputFiles/day1.txt");

            var numbers = meow.Select(int.Parse).ToArray();
            
            Part1(numbers);
            Part2(numbers);

            return Environment.ExitCode;
        }
        
        private static void Part1(int[] numbers)
        {
            var increases = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    increases++;
                }
            }
            Console.WriteLine($"Number of increases: {increases} out of {numbers.Length} measurements");
        }

        private static void Part2(int[] numbers)
        {
            var increases = 0;
            var previousSum = numbers[0] + numbers[1] + numbers[2];

            for (int i = 3; i < numbers.Length; i++)
            {
                var sum = numbers[i] + numbers[i - 1] + numbers[i - 2];
                if (sum > previousSum)
                {
                    increases++;
                }

                previousSum = sum;
            }
            Console.WriteLine($"Number of increases: {increases} out of {numbers.Length} measurements");
        }

    }
}