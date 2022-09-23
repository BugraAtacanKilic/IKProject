using IKProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.Model.Entities
{
    public class Company: BaseEntity
    {
        public Company()
        {
            Users = new HashSet<User>();
            IsActive = true;           
            ActiveUsersLimit = 5;            
        }

        public string Name { get; set; }
        public string MailTag { get; set; }
        public string LogoPath { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public short ActiveUsersLimit { get; set; }    // max 5
        public short ActiveUsersNo { get; set; }    // max 0 limit artacak 
        public ICollection<User> Users { get; set; }
    }
}
