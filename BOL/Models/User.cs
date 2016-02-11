using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BOL.Models
{
    public class User
    {
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

        [HiddenInput]
        public Role Role { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }
        public virtual ICollection<Purse> Purses { get; set; }
        public virtual ICollection<Subscribe> Subscribes { get; set; } 

    }
}
