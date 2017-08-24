using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class User
    {
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 4)]
        [Required]
        public string Email { get; set; }

        [StringLength(60, MinimumLength = 8)]
        [Required]
        public string Password { get; set; }

        public Role Role { get; set; }

        public override string ToString()
        {
            return String.Format("User, Email, Password, Role", Email, Password, Role);
        }
    }
}
