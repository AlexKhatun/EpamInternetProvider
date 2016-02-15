using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class Rate
    {
        public int RateId { get; set; }

        [Required]
        [DisplayName("Id услуги")]
        public int ServiceId { get; set; }

        [DisplayName("Услуга")]
        public Service Service { get; set; }

        [Required]
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Начало действия цены")]
        [DataType(DataType.Date)]
        public DateTime PriceStartDate { get; set; }

        [Required]
        [DisplayName("Окончание действия цены")]
        [DataType(DataType.Date)]
        public DateTime PriceFinishDate { get; set; }

        [DisplayName("Список подписок")]
        public virtual List<Subscribe> Subscribes { get; set; } 
    }
}
