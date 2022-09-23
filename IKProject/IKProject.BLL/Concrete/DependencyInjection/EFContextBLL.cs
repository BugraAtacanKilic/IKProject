using IKProject.BLL.Abstract;
using IKProject.DAL.Concrete.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BLL.Concrete.DependencyInjection
{
    public static class EFContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<IUserBLL, UserService>();
            services.AddScoped<ICompanyBLL, CompanyService>();
            services.AddScoped<IDepartmentBLL, DepartmentService>();
            services.AddScoped<IRolType, RolTypeService>();

        }


    }
}
