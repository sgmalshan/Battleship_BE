using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Core.Entities
{
    public class Ship
    {
        public string Name { get; }
        public int Size { get; }
        public int Hits { get; private set; }
        public bool IsSunk => Hits >= Size;

        public Ship(string name, int size)
        {
            Name = name;
            Size = size;
            Hits = 0;
        }

        public void RegisterHit()
        {
            if (Hits < Size)
                Hits++;
        }
    }
}
