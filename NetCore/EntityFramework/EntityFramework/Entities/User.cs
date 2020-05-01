using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace EntityFramework.Entities
{
    class User
    {
        [Key]
        public Guid UserId { get; set; }

        [MaxLength(64)]
        public string UserName { get; set; }

        public virtual UserPassword Password { get; set; }

        public virtual ICollection<OldPassword> PasswordHistories { get; set; }

        public virtual ICollection<GroupWithUser> Groups { get; set; }
    }
}
