using RazorWebModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorWebService
{
    public interface IEmpoyeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);

        Employee Update(Employee employee);
    }
}
