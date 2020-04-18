using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebModel;
using RazorWebService;

namespace RazorLearning.Pages.Employees
{
    public class EditModel : PageModel
    {
        private IEmpoyeeRepository _repository;

        private IWebHostEnvironment _webHostEnvironment;

        public Employee Employee { get; set; }

        //[BindProperty]
        public IFormFile Photo { get; set; }

        public EditModel(IEmpoyeeRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _webHostEnvironment = webHostEnvironment;
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

        public IActionResult OnPost(Employee employee, IFormFile photo)
        {
            if (Photo != null)
            {
                if (employee.PhotoPath != null)
                {
                    //string fileName = Path.Combine(_webHostEnvironment.WebRootPath, "images", employee.PhotoPath);

                    //if (System.IO.File.Exists(fileName))
                    //{
                    //    System.IO.File.Delete(fileName);
                    //}
                }

                employee.PhotoPath = ProcessUploadedFile(employee);
            }

            Employee = _repository.Update(employee);

            return RedirectToPage("/Employees/Index");
        }

        private string ProcessUploadedFile(Employee employee)
        {
            string uniqueFileName = $"uploaded_{employee.Id}.jpg";

            if (Photo != null)
            {
                string imagesFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");

                string imageFile = Path.Combine(imagesFolder, uniqueFileName);

                if (System.IO.File.Exists(imageFile))
                {
                    System.IO.File.Delete(imageFile);
                }

                using (var fileStream = new FileStream(imageFile, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);

                    fileStream.Flush();
                }
            }

            return uniqueFileName;
        }
    }
}
