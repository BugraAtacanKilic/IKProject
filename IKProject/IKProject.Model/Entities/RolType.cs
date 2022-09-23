using IKProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Model.Entities
{
    public class RolType : BaseEntity
    {
        public RolType()
        {
            IsActive = true;
            Users = new HashSet<User>();
        }

        public string Name { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
