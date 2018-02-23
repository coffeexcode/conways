﻿using GameOfLife;
using GameOfLife.Building;
using GameOfLife.Patterns.Oscillators;
using GameOfLife.Patterns.Shapes;
using GameOfLife.Patterns.Spaceships;
using System;
using System.Text;
using System.Threading;

namespace TerminalGameOfLife
{
    class Program
    {

        public static int Height { get; } = 50;

        public static int Width { get; } = 50;

        public static char AliveChar { get; } = '@';

        public static char EmptyChar { get; } = '.';

        public static int Delay { get; } = 125;

        static void Main(string[] args)
        {
            WorldBuilder builder = new WorldBuilder(40, 160);

            builder.Place(new VerticalLine(5), 0, 0);
            builder.Place(new HorizontalLine(12), 5, 6);

            builder.Place(new VerticalBlinker(), 12, 15);
            builder.Place(new HorizontalBlinker(), 16, 16);

            builder.Place(new Glider(), 20, 20);
            builder.Place(new HeavyweightSpaceship(), 5, 50);

            DisplayWorld(builder.World);

            Play(builder.World);
        }

        static void Play(GameWorld world)
        {
            Console.Clear();
            Console.SetWindowSize(25 + world.Width, 10 + world.Height);

            Console.WriteLine("Welcome to Conway's Game of Life");
            Console.WriteLine("===========================================");
            Console.WriteLine("Your initial world state: ");
            Console.WriteLine($"Size: {world.Height}x{world.Width}");
            DisplayWorld(world);
            Console.WriteLine("\nPress [enter] to start the game...");
            Console.ReadLine();

            Console.Clear();

            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            while (true)
            {
                Console.CursorVisible = false;
                DisplayWorld(world);
                world.NextGeneration();
                Console.SetCursorPosition(0, 0);
                Thread.Sleep(Delay);
            }
        }

        private static void DisplayWorld(GameWorld world)
        {
            
            var builder = new StringBuilder();

            for (int i = 0; i < world.Height; i++)
            {
                for (int j = 0; j < world.Width; j++)
                {
                    builder.Append(world.Get(i, j) ? AliveChar : EmptyChar);
                }
                builder.AppendLine();
            }

            Console.WriteLine(builder.ToString());
            Console.WriteLine($"Generation: {world.Generation}");
        }
    }
}
