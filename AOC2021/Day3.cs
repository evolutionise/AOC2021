using System;
using System.Buffers;
using System.IO;
using Microsoft.VisualBasic;

namespace AOC2021
{
    public static class Day3
    {
        public static int Execute()
        {
            var input = File.ReadAllLines("./InputFiles/day3.txt");
            
            // Okay let's try the naieve implementation of this - no bit fiddling, just lists and indexes

            var atrocity = new int[input.Length][];

            for (int i = 0; i < input.Length; i++)
            {
                var meow = input[i].ToCharArray();
                var omgNoStop = new int[meow.Length];
                for (int j = 0; j < meow.Length; j++)
                {
                    omgNoStop[j] = (int)char.GetNumericValue(meow[j]);
                }

                atrocity[i] = omgNoStop;
            }
            
            // YES I KNOW I COULD DO THIS IN THE FIRST LOOP LEAVE ME ALONE OKAY
            
            // If this 2d array is ragged so help me god
            var absoluteNonsenseGamma = (uint) 0;
            var absoluteNonsenseEpsilon = (uint) 0;
            
            // Oh fuck it this is where i give up all semblance of hope
            // Wait no i realised i can make some assumptions about binary numbers like how many values each bit can have
            // so smart
            var crimes = new int[atrocity[0].Length];

            for (int i = 0; i < atrocity.Length; i++)
            {
                for (int j = 0; j < atrocity[i].Length; j++)
                {
                    if (atrocity[i][j] > 0)
                    {
                        crimes[j]++;
                    }
                }
            }

            var half = input.Length / 2;
            
            Console.WriteLine($"Half = {half}");
            foreach (var crime in crimes)
            {
                // I said no bitshifting but i lied
                absoluteNonsenseGamma <<= 1;
                absoluteNonsenseEpsilon <<= 1;
                
                if (crime > half)
                {
                    absoluteNonsenseGamma += 1;

                }
                else
                {
                    absoluteNonsenseEpsilon += 1;
                }
            }
            
            Console.WriteLine($"Gamma: int = {absoluteNonsenseGamma.ToString()} binary = {Convert.ToString(absoluteNonsenseGamma, toBase: 2)}");
            Console.WriteLine($"Epsilon: int = {absoluteNonsenseEpsilon.ToString()} binary = {Convert.ToString(absoluteNonsenseEpsilon, toBase: 2)}");
            Console.WriteLine($"Answer: {absoluteNonsenseEpsilon * absoluteNonsenseGamma}");


            return Environment.ExitCode;
        }
    }
}