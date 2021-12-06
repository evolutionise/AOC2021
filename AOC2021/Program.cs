using System;
using System.IO;
using System.Linq;

namespace AOC2021
{
    class Program
    {
        static int Main(string[] args)
        {
            return args[0] switch
            {
                "1" => Day1.Execute(),
                "2" => Day2.Execute(),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }
}