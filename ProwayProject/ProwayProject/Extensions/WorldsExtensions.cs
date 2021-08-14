using ProwayProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProwayProject.Extensions
{
    public static class WorldsExtensions
    {
        public static void FillOcean(this World world)
        {
            var random = new Random();

            for (int i = 0; i < world.Ocean.Length; i++)
            {
                for (int j = 0; j < world.Ocean[i].Length; j++)
                {
                    world.Ocean[i][j] = Convert.ToBoolean(random.Next(0, 2));
                }
            }
        }

        public static int CountIslands(this World world)
        {
            int count = 0;
            for (int i = 0; i < world.Ocean.Length; i++)
            {
                for (int j = 0; j < world.Ocean[i].Length; j++)
                {
                    if (IsIsland(world, i, j))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static bool IsIsland(World world, int i, int j)
        {
            var IsIsland = false;
            if (i > 0 && i < world.Ocean.Length - 1 && j > 0 && j < world.Ocean[i].Length - 1)
            {
                var Horizontally = world.Ocean[i - 1][j] && world.Ocean[i + 1][j];
                var Vertical = world.Ocean[i][j - 1] && world.Ocean[i][j + 1];
                var Diagonally = world.Ocean[i - 1][j - 1] && world.Ocean[i - 1][j + 1] && world.Ocean[i + 1][j - 1] && world.Ocean[i + 1][j + 1];
                IsIsland = Horizontally && Vertical && Diagonally;
            }
            return IsIsland;
        }

    }
}

