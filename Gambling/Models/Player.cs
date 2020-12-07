using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int TimesPlayed { get; set; }
        public int TimesWon { get; set; }
        public int TimesLost { get; set; }
        [Required]
        public int Coins { get; set; }
        public int TimesDrank { get; set; }

        public List<int> betAmounts;

        public Player()
        {
            TimesPlayed = 0;
            TimesWon = 0;
            TimesLost = 0;
            TimesDrank = 0;
            betAmounts = new List<int>();
        }
    }
}
