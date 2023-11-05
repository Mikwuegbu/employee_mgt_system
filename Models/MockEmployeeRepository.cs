using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            this._employeesList = new List<Employee>()
            {
                new Employee(){ Id = 101, Name="Stephen", Email = "Msutechnologies@yahoo.com", Department = Dept.IT},
                new Employee(){ Id = 102, Name="Uchechukwu", Email = "Jenniferdavis@yahoo.com", Department = Dept.HR},
                new Employee(){ Id = 103, Name="Mark", Email = "Mstephen130@yahoo.com", Department = Dept.HR}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeesList.Max(e => e.Id)+1;
            _employeesList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeesList.FirstOrDefault(e => e.Id == id);
            if (employee != null!)
            {
                _employeesList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeesList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(e => e.Id == Id);    
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeesList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null!)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
