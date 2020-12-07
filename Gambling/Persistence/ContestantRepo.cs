using Gambling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Persistence
{
    public class ContestantRepo : IContestantRepo
    {
        private DatabaseContext context;

        public ContestantRepo()
        {
            context = new DatabaseContext();
        }

        public async Task<ContestantVotes> AddContestantVotes(ContestantVotes contestantVotes)
        {
            Console.WriteLine("Adding in repo");
            Console.WriteLine($"votes: name: {contestantVotes.ContestantName}, amount: {contestantVotes.Amount}, playerid: {contestantVotes.PlayerID}");
            await context.ContestantVotes.AddAsync(contestantVotes);
            Console.WriteLine("Saving changes");
            await context.SaveChangesAsync();
            Console.WriteLine("Done adding");
            return contestantVotes;
        }

        public async Task<ContestantVotes> GetContestantVote(int id)
        {
            return context.ContestantVotes.First(vote => vote.Id == id);
        }

        public async Task<IList<ContestantVotes>> GetContestantVotesByPlayerID(int id)
        {
            return context.ContestantVotes.Where(vote => vote.PlayerID == id).ToList();
        }

        public async Task RemoveContestantVotes(int id)
        {
            ContestantVotes toRemove = context.ContestantVotes.First(vote => vote.Id == id);
            context.ContestantVotes.Remove(toRemove);
            await context.SaveChangesAsync();
        }

        public async Task<ContestantVotes> UpdateContestantVotes(ContestantVotes contestantVotes)
        {
            context.ContestantVotes.Update(contestantVotes);
            await context.SaveChangesAsync();
            return contestantVotes;
        }
    }
}
