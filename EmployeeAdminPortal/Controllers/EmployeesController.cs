using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext DbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            //return NotFound("result not found");
            List<Employee> allEmployees = DbContext.Employees.ToList();
            #region
            //for (int i = 0; i < 100; i++)
            //{
            //    Employee item = new Employee
            //    {
            //        Name = "Dev",
            //        Email = "panchal@gmail.com",
            //        Phone = "",
            //        Salary = (decimal)50000,
            //        Department = "",
            //        Address = ""
            //    };
            //    allEmployees.Add(item);
            //}
            //var emp = new Employee { Name = "devp", Email = "panchal@x.com", Phone = "", Salary = (decimal)100000, Department = "", Address = "" };
            //Employee item = new Employee("dev", "panchal@gmail.com", "", (decimal)50000, "", "");            
            #endregion
            return Ok(allEmployees);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Email = addEmployeeDto.Email,
                Name = addEmployeeDto.Name,
                Salary = addEmployeeDto.Salary,
                Phone = addEmployeeDto.Phone,
            };
            
            DbContext.Employees.Add(employeeEntity);
            DbContext.SaveChanges();

            return Ok(employeeEntity);
        }
    }
}
