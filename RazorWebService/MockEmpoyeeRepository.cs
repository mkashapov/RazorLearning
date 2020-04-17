using RazorWebModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RazorWebService
{
    public class MockEmpoyeeRepository : IEmpoyeeRepository
    {
        private List<Employee> _allEmployees;

        public MockEmpoyeeRepository()
        {
            _allEmployees = new List<Employee>();
            _allEmployees.Add(new Employee() { Id = 1212, Name = "Ann", BirthDate = DateTime.Now.AddYears(-24), Dept = Dept.Manager, Image="1.jpg" });
            _allEmployees.Add(new Employee() { Id = 2322, Name = "Vika", BirthDate = DateTime.Now.AddYears(-22), Dept = Dept.HR, Image = "2.jpg" });
            _allEmployees.Add(new Employee() { Id = 3435, Name = "Marina", BirthDate = DateTime.Now.AddYears(-34), Dept = Dept.IT, Image = "3.jpg" });
            _allEmployees.Add(new Employee() { Id = 5674, Name = "Sasha", BirthDate = DateTime.Now.AddYears(-24), Dept = Dept.Manager, Image = "4.jpg" });
            _allEmployees.Add(new Employee() { Id = 5624, Name = "Oleg", BirthDate = DateTime.Now.AddYears(-22), Dept = Dept.HR, Image = "5.jpg" });
            _allEmployees.Add(new Employee() { Id = 7654, Name = "Viktor", BirthDate = DateTime.Now.AddYears(-24), Dept = Dept.Manager, Image = "6.jpg" });
            _allEmployees.Add(new Employee() { Id = 7345, Name = "Kris", BirthDate = DateTime.Now.AddYears(-32), Dept = Dept.Manager, Image = "7.jpg" });
            _allEmployees.Add(new Employee() { Id = 8876, Name = "Nina", BirthDate = DateTime.Now.AddYears(-20), Dept = Dept.IT, Image = "8.jpg" });
            _allEmployees.Add(new Employee() { Id = 9434, Name = "Vita", BirthDate = DateTime.Now.AddYears(-14), Dept = Dept.HR, Image = "9.jpg" });
            _allEmployees.Add(new Employee() { Id = 9656, Name = "Peter", BirthDate = DateTime.Now.AddYears(-24), Dept = Dept.IT, Image = "10.jpg" });
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _allEmployees;
        }

        public Employee GetEmployeeById(int id)
        {
            return _allEmployees.Where(e => e.Id == id).SingleOrDefault();
        }
    }
}
