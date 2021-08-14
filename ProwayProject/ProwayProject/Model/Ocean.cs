using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProwayProject.Model
{
    public class World
    {
        public bool[][] Ocean { get; set; }
        public World(int dimension)
        {
            if (dimension < 0)
            {
                throw new ArgumentException("dimension must be a positive integer.", $"{nameof(dimension)}");
            }
            Ocean = new bool[dimension][];
            Ocean = Ocean.Select(Item => new bool[dimension]).ToArray();
        }
    }
}
