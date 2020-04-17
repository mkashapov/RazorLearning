﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebModel;
using RazorWebService;

namespace RazorLearning.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private IEmpoyeeRepository _repository;

        public IEnumerable<Employee> Employees { get; set; }

        public IndexModel(IEmpoyeeRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            this.Employees = _repository.GetAllEmployees();
        }
    }
}