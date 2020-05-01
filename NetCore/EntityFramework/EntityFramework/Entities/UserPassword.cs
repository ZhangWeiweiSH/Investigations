using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Entities
{
    class UserPassword
    {
        [Key]
        public Guid UserId{ get; set; }

        public User User { get; set; }

        public string Password { get; set; }
    }
}
