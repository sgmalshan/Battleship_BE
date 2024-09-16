using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleship.Application.Interfaces;
using Battleship.Core.Entities;

namespace Battleship.Application.Services
{
    public class GameService : IGameService
    {
        private readonly GameState _gameState;

        public GameService(GameState gameState)
        {
            _gameState = gameState;
        }

        public void StartGame()
        {
            _gameState.Board.PlaceShip(new Ship("Battleship", 5), 0, 0, true);
            _gameState.Board.PlaceShip(new Ship("Destroyer", 4), 2, 2, false);
            _gameState.Board.PlaceShip(new Ship("Destroyer", 4), 4, 4, true);
        }

        public string Shoot(string position)
        {
            int x = position[0] - 'A'; // Convert A-J to 0-9
            int y = int.Parse(position.Substring(1)) - 1;

            if (_gameState.Board.RegisterShot(x, y))
            {
                return "Hit!";
            }
            return "Miss!";
        }

        public bool IsGameOver() => _gameState.IsGameOver;
    }
}
