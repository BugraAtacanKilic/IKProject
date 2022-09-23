using IKProject.BLL.Abstract;
using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.ViewModel.CompanyVm;
using IKProject.ViewModel.DepartmentVM;
using IKProject.ViewModel.UsersVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace IKProject.Controllers
{
    public class AdminController : Controller
    {
        IUserBLL _userService;
        ICompanyBLL _companyService;
        IDepartmentBLL _departmentService;
        private readonly IWebHostEnvironment _webhost;
        public AdminController(IUserBLL userService, ICompanyBLL companyService, IDepartmentBLL departmentService, IWebHostEnvironment webhost)
        {
            _userService = userService;
            _companyService = companyService;
            _departmentService = departmentService;
            _webhost = webhost;
        }

        public IActionResult Index()
        {
            int id = 2;
            FillInfo(id);
            ResultService<UserDetailVM> resultActiveUsersLimit = _userService.GetUserDetail(id);
            ViewBag.ActiveUsersLimit = resultActiveUsersLimit.Data.ActiveUsersLimit;          
            List<UserMainPageVM> mainPageList = _userService.GetAllPersonel();
            ViewBag.ActiveUsersNo = mainPageList.Count();
            return View(mainPageList);
        }

        public IActionResult UserList()
        {
            int id = 2;
            FillInfo(id);
            List<UserListVM> resultPersonel = _userService.GetListPersonel();
            return View(resultPersonel);
        }

        public IActionResult UserDetail(int id)
        {
            int id1 = 2;
            FillInfo(id1);
            ResultService<UserDetailVM> resultDetail = _userService.GetUserDetail(id);
            return View(resultDetail.Data);
        }

        public IActionResult AddUser()
        {
            int id = 2;
            FillInfo(id);
            ResultService<CompanyEmailVM> resultmailtag = _companyService.GetMail();
            ResultService<List<DepartmentListVm>> departmentResult = _departmentService.GetList();
            ViewData["DepartmentID"] = new SelectList(departmentResult.Data, "ID", "Name");
            ViewBag.Email = resultmailtag.Data.Email.ToString();

            return View();
        }


        [HttpPost]
        public IActionResult AddUser(UserAddVM userAdd)
        {          
            int id = 2;
            ResultService<UserDetailVM> result1 = _userService.GetUserDetail(id);
            ResultService<CompanyEmailVM> resultmailtag = _companyService.GetMail();
            userAdd.Mail += $"{resultmailtag.Data.Email}";           
            //userAdd.CompanyID = result1.Data.CompanyID;
            if (ModelState.IsValid)
            {
                ResultService<UserAddVM> resultservice = _userService.Create(userAdd);
                if (resultservice.HasError==false)
                {
                    int createdUserID = _userService.GetUserDetailbyTC(userAdd.TC);
                    TempData["SuccessMessage"] = "Kayıt Başarı ile Gerçekleşmiştir.";
                    Uploadİmage(userAdd.PhotoPath, createdUserID.ToString());
                    return RedirectToAction(nameof(AddUser));
                }
                else
                {
                    TempData["SuccessMessage"] = resultservice.Errors.SingleOrDefault().ErrorMessage;
                    return RedirectToAction(nameof(AddUser));
                }                
            }
           
            ResultService<CompanyEmailVM> result = _companyService.GetMail();
            ResultService<List<DepartmentListVm>> departmentResult = _departmentService.GetList();
            ViewData["DepartmentID"] = new SelectList(departmentResult.Data, "ID", "Name");
            ViewBag.Email = result.Data.Email.ToString();
            return View();
        }




        public async Task<IActionResult> UpdateUser(int? id)
        {
            int idYonetici = 2;
            FillInfo(idYonetici);
            if (id == null)
            {
                return NotFound();
            }
            ResultService<UserUpdateVM> resultService = _userService.Edit(id);
            var result = resultService.Data;

            ResultService<List<DepartmentListVm>> departmentResult = _departmentService.GetList();
            ViewData["DepartmentID"] = new SelectList(departmentResult.Data, "ID", "Name");
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserUpdateVM userUpdate)
        {
            int idYonetici = 2;
            if (ModelState.IsValid)
            {
                ResultService<bool> result = _userService.EditSave(userUpdate);         
                FillInfo(idYonetici);
                TempData["SuccessMessage"] = "Güncelleme Başarı ile Gerçekleşmiştir.";
                return View();
                
            }

            ResultService<List<DepartmentListVm>> departmentResult = _departmentService.GetList();
            ViewData["DepartmentID"] = new SelectList(departmentResult.Data, "ID", "Name");
           
            FillInfo(idYonetici);
            return View();
        }

       
        public bool Uploadİmage (IFormFile imgfile, string id)
        {
            string imgextension = Path.GetExtension(imgfile.FileName); 
            bool result = false;
            string filepath = Path.Combine(_webhost.WebRootPath, "assets/img/Users", id+imgextension);
            using (var filestream = new FileStream(filepath, FileMode.Create))
            {
                imgfile.CopyTo(filestream);
                result = true;
                ResultService<bool> updatedpic = _userService.EditUserPic(Convert.ToInt32(id), @"Users/"+id + imgextension);
            }
                return result;    
        }

        public void FillInfo(int id)
        {
            ResultService<UserDetailVM> resultYonetici = _userService.GetUserDetail(id);
            TempData["CompanyPhoto"] = resultYonetici.Data.CompanyPhoto;
            TempData["EmployePhoto"] = resultYonetici.Data.PhotoPath;
            TempData["EmployeName"] = resultYonetici.Data.FullName;
            TempData["CompanyName"] = resultYonetici.Data.CompanyName;
        }
    }
}
