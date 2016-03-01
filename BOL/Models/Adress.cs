using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BOL.Models
{
    public class Adress
    {
        public int AdressId { get; set; }

        [Required]
        [HiddenInput]
        [DisplayName("Id пользователя")]
        public int UserId { get; set; }

        [DisplayName("Пользователь")]
        public virtual User User { get; set; }

        [Required]
        [DisplayName("Город")]
        public string City { get; set; }

        [Required]
        [DisplayName("Улица")]
        public string Street { get; set; }

        [Required]
        [DisplayName("Дом")]
        public string House { get; set; }

        [Required]
        [DisplayName("Квартира")]
        public string Flat { get; set; }

        [Required]
        [DisplayName("Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
