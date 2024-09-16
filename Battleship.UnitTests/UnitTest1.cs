using Battleship.Application.Services;
using Battleship.Core.Entities;

namespace Battleship.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestShoot_Hit()
        {
            var gameState = new GameState();
            var gameService = new GameService(gameState);
            gameService.StartGame();

            var result = gameService.Shoot("A1");
            Assert.Equal("Hit!", result);
        }

        [Fact]
        public void TestShoot_Miss()
        {
            var gameState = new GameState();
            var gameService = new GameService(gameState);
            gameService.StartGame();

            var result = gameService.Shoot("J10");
            Assert.Equal("Miss!", result);
        }
    }
}