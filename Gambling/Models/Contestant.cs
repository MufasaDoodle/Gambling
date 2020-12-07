using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gambling.Models
{
    public class Contestant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Offset { get; set; }
        [Required]
        public string Picture { get; set; }
    }
}
