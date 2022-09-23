using IKProject.BLL.Concrete.ResultSeviceBLL;
using IKProject.Model.Entities;
using IKProject.ViewModel.DepartmentVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BLL.Abstract
{
    public interface IDepartmentBLL : IBaseBLL<Department>
    {
        ResultService<List<DepartmentListVm>> GetList();
    }
}
