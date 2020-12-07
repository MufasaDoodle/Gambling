using Gambling.Models;
using Gambling.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Data
{
    public class PlayerService : IPlayerService
    {
        IPlayerRepo repo;
        IContestantRepo contestantRepo;
        private int playerToView;

        public PlayerService()
        {
            repo = new PlayerRepo();
            contestantRepo = new ContestantRepo();
        }

        public async Task<ContestantVotes> AddContestantVotes(ContestantVotes contestantVotes)
        {
            Console.WriteLine("Adding in service");
            return await contestantRepo.AddContestantVotes(contestantVotes);
        }

        public async Task<Player> AddPlayer(Player player)
        {
            return await repo.AddPlayer(player);
        }

        public async Task<IList<Player>> GetAllPlayers()
        {
            return await repo.GetAllPlayers();
        }

        public async Task<ContestantVotes> GetContestantVote(int id)
        {
            return await contestantRepo.GetContestantVote(id);
        }

        public async Task<IList<ContestantVotes>> GetContestantVotesByPlayerID(int id)
        {
            return await contestantRepo.GetContestantVotesByPlayerID(id);
        }

        public async Task<Player> GetPlayer(int id)
        {
            return await repo.GetPlayer(id);
        }

        public int GetViewPlayer()
        {
            return playerToView;
        }

        public async Task RemoveContestantVotes(int id)
        {
            await contestantRepo.RemoveContestantVotes(id);
        }

        public async Task RemovePlayer(int id)
        {
            await repo.RemovePlayer(id);
        }

        public void SetViewPlayer(int id)
        {
            playerToView = id;
        }

        public async Task<ContestantVotes> UpdateContestantVotes(ContestantVotes contestantVotes)
        {
            return await contestantRepo.UpdateContestantVotes(contestantVotes);
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            return await repo.UpdatePlayer(player);
        }
    }
}
