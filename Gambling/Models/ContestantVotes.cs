using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Models
{
    public class ContestantVotes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ContestantName { get; set; }
        [Required]
        public int Amount { get; set; }
        public int PlayerID { get; set; }
    }
}
