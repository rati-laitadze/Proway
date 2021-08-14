using ProwayProject.Extensions;
using ProwayProject.Model;
using System;

namespace ProwayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDimensionInt = int.TryParse(Console.ReadLine(), out int dimension);
            if (isDimensionInt)
            {
                var world = new World(dimension);
                world.FillOcean();
                Console.WriteLine($"{world.CountIslands()}");
            }
            else
            {
                throw new ArgumentException("dimension must be a integer.", $"{nameof(dimension)}");
            }
        }
    }
}
