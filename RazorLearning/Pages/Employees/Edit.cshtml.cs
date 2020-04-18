using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebModel;
using RazorWebService;

namespace RazorLearning.Pages.Employees
{
    public class EditModel : PageModel
    {
        private IEmpoyeeRepository _repository;

        public Employee Employee { get; set; }

        public EditModel(IEmpoyeeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet(int id)
        {
            Employee = _repository.GetEmployeeById(id);

            if (Employee == null)
            {
                return RedirectToPage(@"/Employees/NotFound");
            }

            return this.Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            Employee = _repository.Update(employee);

            return RedirectToPage("/Employees/Index");
        }
    }
}
