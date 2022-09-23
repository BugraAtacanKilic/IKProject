using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.Model.Entities;
using IKProject.ViewModel.UsersVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BLL.Abstract
{
    public interface IUserBLL : IBaseBLL<User>
    {
        List<UserMainPageVM> GetAllPersonel();
        List<UserListVM> GetListPersonel();
        ResultService<UserAddVM> Create(UserAddVM userAdd);
        ResultService<UserDetailVM> GetUserDetail(int id);
        ResultService<UserUpdateVM> Edit(int? id);
        ResultService<UserLoginVM> GetUserByRolTypeID(string password, string email);
        ResultService<bool> EditSave(UserUpdateVM userUpdate);
        int GetUserDetailbyTC(string tC);
        ResultService<bool> EditUserPic(int v1, string v2);
    }
}
