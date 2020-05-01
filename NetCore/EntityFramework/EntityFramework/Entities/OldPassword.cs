using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFramework.Entities
{
    class OldPassword
    {
        public Int64 Id { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public string Password { get; set; }

        public DateTime ChangedDate { get; set; }
    }
}
