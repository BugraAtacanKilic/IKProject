using IKProject.BLL.Abstract;
using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.DAL.Abstract;
using IKProject.ViewModel.CompanyVm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BLL.Concrete
{
    class CompanyService : ICompanyBLL
    {


        ICompanyDAL _companyRepository;
        public CompanyService(ICompanyDAL companyRepository)
        {
            _companyRepository = companyRepository;
        }


        public ResultService<CompanyEmailVM> GetMail()
        {
            ResultService<CompanyEmailVM> resultService = new ResultService<CompanyEmailVM>();
            try
            {
                var resultMail = _companyRepository.Get(a => a.IsActive);

                var Total = new CompanyEmailVM()
                {
                    Email = resultMail.MailTag,
                };

                resultService.Data = Total;
            }
            catch (Exception)
            {

                throw;
            }

            return resultService;

        }
    }
}
