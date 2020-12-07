using Gambling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Persistence
{
    interface IPlayerRepo
    {
        Task<Player> AddPlayer(Player player);
        Task<IList<Player>> GetAllPlayers();
        Task<Player> GetPlayer(int id);
        Task RemovePlayer(int id);
        Task<Player> UpdatePlayer(Player player);
    }
}
