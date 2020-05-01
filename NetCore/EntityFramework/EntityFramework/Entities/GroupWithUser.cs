using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Entities
{
    class GroupWithUser
    {
        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public Guid GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
