using System;
using System.Collections.Generic;
using System.Text;

namespace RazorWebModel
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public Dept Dept { get; set; }

        public string Image { get; set; }
    }
}
