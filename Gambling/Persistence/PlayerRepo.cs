using Gambling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Persistence
{
    public class PlayerRepo : IPlayerRepo
    {
        private DatabaseContext context;

        public PlayerRepo()
        {
            context = new DatabaseContext();
        }

        public async Task<Player> AddPlayer(Player player)
        {
            await context.Players.AddAsync(player);
            await context.SaveChangesAsync();
            return player;
        }

        public async Task<IList<Player>> GetAllPlayers()
        {
            return context.Players.ToList();
        }

        public async Task<Player> GetPlayer(int id)
        {
            return context.Players.First(player => player.Id == id);
        }

        public async Task RemovePlayer(int id)
        {
            Player toRemove = context.Players.First(player => player.Id == id);
            context.Players.Remove(toRemove);
            await context.SaveChangesAsync();
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            context.Players.Update(player);
            await context.SaveChangesAsync();
            return player;
        }
    }
}
