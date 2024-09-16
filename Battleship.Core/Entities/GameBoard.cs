using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Core.Entities
{
    public class GameBoard
    {
        private const int GridSize = 10;
        private readonly char[,] _grid;
        public List<Ship> Ships { get; }

        public GameBoard()
        {
            _grid = new char[GridSize, GridSize];
            Ships = new List<Ship>();
        }

        public void PlaceShip(Ship ship, int x, int y, bool horizontal)
        {
            // Logic to place the ship on the board
            for (int i = 0; i < ship.Size; i++)
            {
                if (horizontal)
                    _grid[x, y + i] = 'S';
                else
                    _grid[x + i, y] = 'S';
            }
            Ships.Add(ship);
        }

        public bool RegisterShot(int x, int y)
        {
            if (_grid[x, y] == 'S')
            {
                _grid[x, y] = 'X'; // Hit
                return true;
            }
            _grid[x, y] = 'M'; // Miss
            return false;
        }

        public char[,] GetGrid() => _grid;
    }
}
