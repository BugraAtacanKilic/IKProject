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
    internal class DepartmentRepository : EFRepositoryBase<Department, IKProjectDbContext>, IDepartmentDAL
    {

        public DepartmentRepository(IKProjectDbContext context) : base(context)
        {

        }

    }
}
