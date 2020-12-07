using Gambling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Data
{
    interface IPlayerService
    {
        Task<Player> AddPlayer(Player player);
        Task<IList<Player>> GetAllPlayers();
        Task<Player> GetPlayer(int id);
        Task RemovePlayer(int id);
        Task<Player> UpdatePlayer(Player player);

        void SetViewPlayer(int id);
        int GetViewPlayer();

        Task<ContestantVotes> AddContestantVotes(ContestantVotes contestantVotes);
        Task<IList<ContestantVotes>> GetContestantVotesByPlayerID(int id);
        Task<ContestantVotes> GetContestantVote(int id);
        Task RemoveContestantVotes(int id);
        Task<ContestantVotes> UpdateContestantVotes(ContestantVotes contestantVotes);
    }
}
