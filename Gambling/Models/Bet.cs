using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Models
{
    public class Bet
    {
        public string ContestantName { get; set; }
        public string PlayerName { get; set; }
        public int Amount { get; set; }
    }
}
