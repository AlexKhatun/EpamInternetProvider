using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public ServiceType ServiceType { get; set; }

        public virtual ICollection<Rate> Rates { get; set; } 
    }
}
