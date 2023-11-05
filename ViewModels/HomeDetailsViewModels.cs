using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Controllers;
using EmployeeManagement.Models;

namespace EmployeeManagement.ViewModels
{
    public class HomeDetailsViewModels
    {
        public  Employee Employee { get; set; }
        public string PageTitle { get; set; }
    }
}
