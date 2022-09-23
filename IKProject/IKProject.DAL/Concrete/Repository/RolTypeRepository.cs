using IKProject.Core.DataAccess.EntityFramework;
using IKProject.DAL.Abstract;
using IKProject.DAL.Concrete.Context;
using IKProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DAL.Concrete.Repository
{
    class RolTypeRepository : EFRepositoryBase<RolType, IKProjectDbContext>, IRolTypeDAL
    {
        public RolTypeRepository(IKProjectDbContext context) : base(context)
        {
        }
    }
}
