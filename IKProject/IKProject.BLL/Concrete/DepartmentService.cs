using IKProject.BLL.Abstract;
using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.DAL.Abstract;
using IKProject.ViewModel.DepartmentVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BLL.Concrete
{
    class DepartmentService : IDepartmentBLL
    {
        IDepartmentDAL _departmentRepository;

        public DepartmentService(IDepartmentDAL departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public ResultService<List<DepartmentListVm>> GetList()
        {
            ResultService<List<DepartmentListVm>> resultServices = new ResultService<List<DepartmentListVm>>();

            try
            {
                List<DepartmentListVm> result = _departmentRepository.GetAll(a => a.IsActive)
                    .Select(departmaneName => new DepartmentListVm
                    {
                        ID = departmaneName.ID,
                        Name = departmaneName.Name,
                    }).ToList();

                resultServices.Data = result;
            }
            catch (Exception)
            {

                throw;
            }
            return resultServices;
        }
    }
}
