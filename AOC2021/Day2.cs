using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOC2021
{
    public static class Day2
    {
        public static int Execute()
        {
            var cats = Directory.GetCurrentDirectory();
            var meow = File.ReadAllLines("./InputFiles/day2.txt");

            var directions = meow.Select(x =>
            {
                var direction = x.Split(" ");
                return new KeyValuePair<Direction, int>(Enum.Parse<Direction>(direction[0]), int.Parse(direction[1]));
            });

            var coords = new Coordinates();
            
            foreach (var (direction, value) in directions)
            {
                coords.Move(direction, value);
            }
            
            Console.WriteLine($"Final position: X {coords.X} Y {coords.Y} - output {coords.X * coords.Y}");

            return Environment.ExitCode;
        }
    }

    public enum Direction
    {
        up = 0,
        down = 1,
        forward = 2,
      //  back = 3,
    }

    public class Coordinates
    {
        public int X;
        public int Y;

        public Coordinates()
        {
            X = 0;
            Y = 0;
        }

        public void Move(Direction direction, int value)
        {
            switch (direction)
            {
                case Direction.forward:
                    Y += value;
                    break;
                case Direction.down:
                    X += value;
                    break;
                case Direction.up:
                    X -= value;
                    break;

            }
        }
    }
}