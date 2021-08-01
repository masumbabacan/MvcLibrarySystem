using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        Employee GetById(int id);

        void Add(Employee employee);

        void Delete(Employee employee);

        void Update(Employee employee);
    }
}
