using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Interfaces
{
    public interface IGameService
    {
        void StartGame();
        string Shoot(string position);
        bool IsGameOver();
    }
}
