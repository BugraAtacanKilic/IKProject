using IKProject.Core.DataAccess.EntityFramework;
using IKProject.DAL.Abstract;
using IKProject.DAL.Concrete.Context;
using IKProject.Model.Entities;

namespace IKProject.DAL.Concrete.Repository
{
     class UserRepository : EFRepositoryBase<User, IKProjectDbContext>, IUserDAL
    {

        public UserRepository(IKProjectDbContext context) : base(context)
        {

        }


    }
}
