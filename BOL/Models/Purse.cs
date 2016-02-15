using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Id пользователя")]
        public int UserId { get; set; }

        [DisplayName("Пользователь")]
        public User User { get; set; }

        [Required]
        [DisplayName("Название кошелька")]
        public string Title { get; set; }
    }
}
