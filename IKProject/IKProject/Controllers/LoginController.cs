using IKProject.BLL.Abstract;
using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.ViewModel.UsersVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProject.Controllers
{
    public class LoginController : Controller
    {
        IUserBLL _userService;

        public LoginController(IUserBLL userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string password, string email)
        {
            ResultService<UserLoginVM> resultDetail = _userService.GetUserByRolTypeID(password, email);

            if (resultDetail.Data.Email == email && resultDetail.Data.Password == password)
            {
                if (resultDetail.Data.IsActive)
                {
                    //Session["rolTypeID"] = resultDetail.Data.RolTypeID.ToString();
                    HttpContext.Session.SetInt32("rolTypeID", resultDetail.Data.RolTypeID);
                    return RedirectToAction(nameof(NewPassword));

                }
                else
                {
                    //personel aktif değildir hatası dönecek.
                }

            }


            return View(resultDetail);
        }


        public IActionResult ForgetMyPassword()
        {
            return View();
        }

        public IActionResult NewPassword()
        {
            return View();
        }


    }
}
