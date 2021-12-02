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
                "2" => Day2(),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }

        private static int Day2()
        {
            throw new NotImplementedException();
        }
    }
}