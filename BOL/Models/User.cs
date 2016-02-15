using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BOL.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Город")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [HiddenInput]
        [DisplayName("Пользователь удален")]
        public bool IsDeleted { get; set; }

        [HiddenInput]
        [DisplayName("Пользователь зарегистрирован")]
        public bool IsRegister { get; set; }

        [Required]
        [DisplayName("Id роли")]
        public int RoleId { get; set; }

        [HiddenInput]
        [DisplayName("Роль")]
        public virtual Role Role { get; set; }

        [DisplayName("Список адресов")]
        public virtual List<Adress> Adresses { get; set; }
        [DisplayName("Список кошельков")]
        public virtual List<Purse> Purses { get; set; }
        [DisplayName("Список подписок")]
        public virtual List<Subscribe> Subscribes { get; set; } 

    }
}
