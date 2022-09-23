using IKProject.DAL.Abstract;
using IKProject.DAL.Concrete.Context;
using IKProject.DAL.Concrete.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace IKProject.DAL.Concrete.DependencyInjection
{
    public static class EFContextDAL
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {

            services.AddDbContext<IKProjectDbContext>();
            services.AddScoped<IUserDAL, UserRepository>();
            services.AddScoped<ICompanyDAL, CompanyRepository>();
            services.AddScoped<IDepartmentDAL, DepartmentRepository>();
            services.AddScoped<IRolTypeDAL, RolTypeRepository>();

        }

    }
}
