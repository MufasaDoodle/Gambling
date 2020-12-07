using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gambling.Models;

namespace Gambling.Persistence
{
    interface IContestantRepo
    {
        Task<ContestantVotes> AddContestantVotes(ContestantVotes contestantVotes);
        Task<IList<ContestantVotes>> GetContestantVotesByPlayerID(int id);
        Task<ContestantVotes> GetContestantVote(int id);
        Task RemoveContestantVotes(int id);
        Task<ContestantVotes> UpdateContestantVotes(ContestantVotes contestantVotes);
    }
}
