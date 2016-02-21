using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Название услуги")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Id типа услуги")]
        public int ServiceTypeId { get; set; }

        [DisplayName("Тип услуги")]
        public ServiceType ServiceType { get; set; }

        [DisplayName("Список тарифов")]
        public virtual List<Rate> Rates { get; set; } 
    }
}
