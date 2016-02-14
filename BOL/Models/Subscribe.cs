using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class Subscribe
    {
        public int SubscribeId { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public int RateId { get; set; }

        public Rate Rate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime SubscribeDate { get; set; }
    }
}
