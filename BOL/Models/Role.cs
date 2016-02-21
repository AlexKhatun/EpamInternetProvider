using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        [DisplayName("Название роли")]
        public string Title { get; set; }

        [DisplayName("Список пользователей")]
        public virtual List<User> Users { get; set; } 
    }
}
