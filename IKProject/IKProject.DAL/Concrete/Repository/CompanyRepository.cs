using IKProject.Core.DataAccess.EntityFramework;
using IKProject.DAL.Abstract;
using IKProject.DAL.Concrete.Context;
using IKProject.Model.Entities;

namespace IKProject.DAL.Concrete.Repository
{
    class CompanyRepository : EFRepositoryBase<Company, IKProjectDbContext>, ICompanyDAL
    {


        public CompanyRepository(IKProjectDbContext context) : base(context)
        {

        }


    }
}
