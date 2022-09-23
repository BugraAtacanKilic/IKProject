using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.ViewModel.UsersVM
{
    public class UserLoginVM
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public int RolTypeID { get; set; }

        public bool IsActive { get; set; }
    }
}
