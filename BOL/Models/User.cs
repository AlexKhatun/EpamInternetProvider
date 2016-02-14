using System;
using System.Collections.Generic;
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
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [HiddenInput]
        public bool IsDeleted { get; set; }

        [Required]
        public int RoleId { get; set; }

        [HiddenInput]
        public virtual Role Role { get; set; }

        public virtual List<Adress> Adresses { get; set; }
        public virtual List<Purse> Purses { get; set; }
        public virtual List<Subscribe> Subscribes { get; set; } 

    }
}
