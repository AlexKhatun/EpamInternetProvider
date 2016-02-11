using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class Purse
    {
        public int PurseId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
