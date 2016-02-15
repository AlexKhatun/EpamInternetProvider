using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Название")]
        public string Title { get; set; }

        [DisplayName("Списк услуг")]
        public virtual List<Service> Services { get; set; }
    }
}
