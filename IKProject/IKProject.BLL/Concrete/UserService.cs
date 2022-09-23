using IKProject.BLL.Abstract;
using IKProject.BLL.Concrete.PasswordSeviceBLL;
using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.BLL.Concrete.SendMailServiceBLL;
using IKProject.DAL.Abstract;
using IKProject.Model.Entities;
using IKProject.ViewModel.UsersVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BLL.Concrete
{
    class UserService : IUserBLL
    {
        IUserDAL _userDal;
        public UserService(IUserDAL userDal)
        {
            _userDal = userDal;
        }



        /// <summary>
        /// User Yeni Ekleme Create 
        /// </summary>
        /// <param name="userAdd"></param>
        /// <returns></returns>
        public ResultService<UserAddVM> Create(UserAddVM userAdd)
        {
            ResultService<UserAddVM> createResult = new ResultService<UserAddVM>();

            string passwordNew = PasswordService.NewPasswordMethod();
            string passwordMd5 = PasswordService.PasswordMd5(passwordNew);

            try
            {
                User newUserAdd = _userDal.Add(
                    new User
                    {
                        Name = userAdd.Name,
                        Surname = userAdd.Surname,
                        Mail = userAdd.Mail,
                        TC = userAdd.TC,
                        BirthDate = userAdd.BirthDate.Date,
                        Title = userAdd.Title,
                        StartDate = userAdd.StartDate.Date,
                        PhoneNumber = userAdd.PhoneNumber,
                        Adress = userAdd.Adress,
                        Password = passwordMd5,
                        DepartmentID = userAdd.DepartmentID,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsActive = false,
                        RolTypeID = 3,
                        CompanyID = 1
                    });


                if (newUserAdd == null)
                {
                    throw new Exception("ekleme başarılı değil");
                }

                bool isSend = SendMailService.SendMail($"{newUserAdd.Name} {newUserAdd.Surname}", newUserAdd.Mail, newUserAdd.TC, passwordNew);
                if (!isSend)
                {
                    createResult.AddError("mailHatasi", "mail gönderilemedi");
                    return createResult;
                }


                createResult.Data = userAdd;

            }
            catch (Exception ex)
            {

                createResult.AddError("Exception", ex.Message);
            }

            return createResult;
        }

        public List<UserMainPageVM> GetAllPersonel()
        {
            List<UserMainPageVM> mainPageList = _userDal.GetAll(a => a.IsActive, a => a.Department, b => b.Company)
                                                .Select(user => new UserMainPageVM
                                                {
                                                    ID = user.ID,
                                                    AdSoyad = user.Name + " " + user.Surname,
                                                    Departman = user.Department.Name,
                                                    Unvan = user.Title,
                                                    Telefon = user.PhoneNumber,
                                                    Mail = user.Mail,
                                                    PhotoPath = user.PhotoUrlPath
                                                }).ToList();
            return mainPageList;
        }

        public List<UserListVM> GetListPersonel()
        {

            List<UserListVM> result = _userDal.GetAll(null, a => a.Department, b => b.Company)
                                                .Select(user => new UserListVM
                                                {
                                                    ID = user.ID,
                                                    FullName = user.Name + " " + user.Surname,
                                                    BirthDate = user.BirthDate,
                                                    Departman = user.Department.Name,
                                                    Email = user.Mail,
                                                    IsActive = user.IsActive == true ? "Aktif" : "Pasif",
                                                    PhoneNumber = user.PhoneNumber,
                                                    Title = user.Title,
                                                    StartDate = user.StartDate,
                                                    PhotoPath = user.PhotoUrlPath
                                                }).ToList();
            return result;
        }

        public ResultService<UserDetailVM> GetUserDetail(int id)
        {
            ResultService<UserDetailVM> userResult = new ResultService<UserDetailVM>();

            try
            {
                User userDetail = _userDal.Get(a => a.ID == id, a => a.Department, b => b.Company);

                var data = new UserDetailVM
                {
                    ID = userDetail.ID,
                    FullName = userDetail.Name + " " + userDetail.Surname,
                    Email = userDetail.Mail,
                    PhoneNumber = userDetail.PhoneNumber,
                    TCKimlik = userDetail.TC,
                    BirthDate = userDetail.BirthDate,
                    Address = userDetail.Adress,
                    Unvan = userDetail.Title,
                    Departman = userDetail.Department.Name,
                    StartDate = userDetail.StartDate,
                    EndDate = userDetail.EndDate == null ? "Halen Devam Ediyor" : userDetail.EndDate.ToString(),
                    IsActive = userDetail.IsActive == true ? "Aktif" : "Pasif",
                    CompanyPhoto = userDetail.Company.LogoPath,
                    CompanyName = userDetail.Company.Name,
                    PhotoPath = userDetail.PhotoUrlPath,
                    ActiveUsersLimit = userDetail.Company.ActiveUsersLimit,
                    ActiveUsersNo = userDetail.Company.ActiveUsersNo,
                    CompanyID = userDetail.CompanyID
                };

                userResult.Data = data;
            }
            catch (Exception ex)
            {

                userResult.AddError("Exception", ex.Message);
            }

            return userResult;
        }

        public ResultService<UserUpdateVM> Edit(int? id)
        {
            ResultService<UserUpdateVM> userResult = new ResultService<UserUpdateVM>();
            try
            {
                User editUser = _userDal.Get(a => a.ID == id, p => p.Company, b => b.Department);

                if (editUser.EndDate == null)
                {
                    editUser.EndDate = default(DateTime);
                }

                var data = new UserUpdateVM
                {
                    ID = editUser.ID,
                    Adress = editUser.Adress,
                    BirthDate = editUser.BirthDate,
                    DepartmentID = editUser.DepartmentID,
                    Name = editUser.Name,
                    Surname = editUser.Surname,
                    EndDate = (DateTime)editUser.EndDate,
                    PhoneNumber = editUser.PhoneNumber,
                    StartDate = editUser.StartDate,
                    Title = editUser.Title,
                    IsActive = editUser.IsActive
                };

                userResult.Data = data;
            }
            catch (Exception ex)
            {

                userResult.AddError("Exception", ex.Message);
            }

            return userResult;
        }

        public ResultService<bool> EditSave(UserUpdateVM userUpdate)
        {


            ResultService<bool> result = new();
            User updatedUser = _userDal.Get(a => a.ID == userUpdate.ID, p => p.Company, b => b.Department);
            updatedUser.Name = userUpdate.Name;
            updatedUser.Surname = userUpdate.Surname;
            updatedUser.BirthDate = userUpdate.BirthDate;
            updatedUser.Title = userUpdate.Title;
            updatedUser.PhoneNumber = userUpdate.PhoneNumber;
            updatedUser.DepartmentID = userUpdate.DepartmentID;
            updatedUser.StartDate = userUpdate.StartDate;
            updatedUser.EndDate = userUpdate.EndDate;
            updatedUser.Adress = userUpdate.Adress;
            updatedUser.IsActive = userUpdate.IsActive;
            User checkUser = _userDal.Update(updatedUser);
            if (checkUser != null)
                result.Data = true;
            else
                result.Data = false;
            return result;
        }

        public int GetUserDetailbyTC(string tC)
        {
            User user = _userDal.Get(a => a.TC == tC, a => a.Department, b => b.Company);

            return user.ID;
        }

        public ResultService<bool> EditUserPic(int v1, string v2)
        {
            ResultService<bool> result = new();
            User updatedUser = _userDal.Get(a => a.ID == v1, p => p.Company, b => b.Department);
            updatedUser.PhotoUrlPath = v2;
            User checkUser = _userDal.Update(updatedUser);
            if (checkUser != null)
                result.Data = true;
            else
                result.Data = false;
            return result;
        }

        public ResultService<UserLoginVM> GetUserByRolTypeID(string password, string email)
        {
            //string passwordMd5 = PasswordService.PasswordMd5(password);
            ResultService<UserLoginVM> userResult = new ResultService<UserLoginVM>();
        
            User userRolType = _userDal.Get(a => a.Mail == email && a.Password== password, a => a.RolType);

            var data = new UserLoginVM
            {
                           
                Password= userRolType.Password,
                Email=userRolType.Mail,
                RolTypeID=userRolType.RolTypeID,
                IsActive=userRolType.IsActive
                
            };
            userResult.Data = data;

            return userResult;

        }
    }
}
