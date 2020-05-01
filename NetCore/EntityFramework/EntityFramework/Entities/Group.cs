using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Entities
{
    class Group
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public virtual ICollection<GroupWithUser> Users { get; set; }
    }
}

