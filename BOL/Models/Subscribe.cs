using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Id пользователя")]
        public int UserId { get; set; }

        [DisplayName("Пользователь")]
        public User User { get; set; }

        [Required]
        [DisplayName("Id тарифа")]
        public int RateId { get; set; }

        [DisplayName("Тариф")]
        public Rate Rate { get; set; }

        [Required]
        [DisplayName("Дата начала подписки")]
        [DataType(DataType.Date)]
        public DateTime SubscribeDate { get; set; }
    }
}
