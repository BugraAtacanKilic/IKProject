using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.Model.Entities;
using IKProject.ViewModel.CompanyVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BLL.Abstract
{
    public interface ICompanyBLL : IBaseBLL<Company>
    {
        ResultService<CompanyEmailVM> GetMail();
    }
}
