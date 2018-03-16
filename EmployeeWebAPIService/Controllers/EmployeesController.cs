using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeWebAPIService.Controllers
{
    public class EmployeesController : ApiController
    {
       public IEnumerable<Employee> Get()
        {
            using (NorthwindEntities entities = new NorthwindEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int code)
        {
            using (NorthwindEntities entities = new NorthwindEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.EmployeeID == code);
            }
        }
    }
}
