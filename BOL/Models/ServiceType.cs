using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class ServiceType
    {
        public int ServiceTypeId { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
