using AwayFromKeyboard.Models;
using AwayFromKeyboard.MongoDBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AwayFromKeyboard.APIs
{
    public class EmployeeController : ApiController
    {


        //Get api/values/ list of all employees from local array
        public IEnumerable<Employee> Get()
        {
            return new List<Employee>()
            {
                new Employee() { Employee_ID = 1, Name = "Mholi"},
                new Employee() { Employee_ID = 2, Name = "Zak"},
                new Employee() { Employee_ID = 3, Name = "Malick"},
                new Employee() { Employee_ID = 4, Name = "Nick"},
                new Employee() { Employee_ID = 5,  Name = "Chad" }
                };
        }
        //Get api/values/ selected employees
        public Employee Get(int id)
        {

            if (id == 1)
            {
                return new Employee() { Employee_ID = 1, Name = "Mholi" };
            }
            if (id == 2)
            {
                return new Employee() { Employee_ID = 2, Name = "Zak" };

            }
            if (id == 3)
            {
                return new Employee() { Employee_ID = 3, Name = "Malick" };

            }
            if (id == 4)
            {
                return new Employee() { Employee_ID = 4, Name = "Nick" };

            }
            if (id == 5)
            {
                return new Employee() { Employee_ID = 5, Name = "Chad" };

            }


            return null;
        }
    }
}
