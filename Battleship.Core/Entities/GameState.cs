using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Core.Entities
{
    public class GameState
    {
        public GameBoard Board { get; }
        public bool IsGameOver => Board.Ships.All(ship => ship.IsSunk);

        public GameState()
        {
            Board = new GameBoard();
        }
    }
}
