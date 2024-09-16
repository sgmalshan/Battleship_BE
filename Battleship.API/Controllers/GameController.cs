using Battleship.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Battleship.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("start")]
        public IActionResult StartGame()
        {
            _gameService.StartGame();
            return Ok("Game started.");
        }

        [HttpPost("shoot")]
        public IActionResult Shoot([FromForm] string position)
        {
            var result = _gameService.Shoot(position);
            return Ok(result);
        }

        [HttpGet("isGameOver")]
        public IActionResult IsGameOver()
        {
            var result = _gameService.IsGameOver();
            return Ok(result);
        }
    }
}
