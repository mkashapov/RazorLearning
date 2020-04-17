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
    public class DetailsModel : PageModel
    {
        private IEmpoyeeRepository _repository;

        public Employee Employee { get; set; }

        public DetailsModel(IEmpoyeeRepository repository)
        {
            _repository = repository;
        }

        //[BindProperty(SupportsGet = true)]
        //public int Id { get; set; }

        public void OnGet(int id)
        {
            Employee = _repository.GetEmployeeById(id);
        }
    }
}
