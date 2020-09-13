using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elina.K.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Elina.K.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampingStudentsController : ControllerBase
    {
        private List<Students> students;

        public CampingStudentsController()
        {
            students = new List<Students>()
            {
                new Students() { ID = 101, Name = "Maira", Surname = "Mukanova", Birthday = new DateTime(1998, 05, 01)},
                 new Students() { ID = 102, Name = "Elina", Surname = "Kasim", Birthday = new DateTime(2001, 05, 21)},
                  new Students() { ID = 103, Name = "Aray", Surname = "Beisenova", Birthday = new DateTime(1999, 07, 06)},
                   new Students() { ID = 104, Name = "Nazerke", Surname = "Aley", Birthday = new DateTime(1997, 10, 01)},
                    new Students() { ID = 105, Name = "Dina", Surname = "Ashimova", Birthday = new DateTime(2002, 12, 18)},
            };
        }

        [HttpGet]
        public List<Students> GetAllStudents()
        {
            return students;
        }

        [HttpGet ("name/{name}")] 
        public Students GetStudentsWithName(string name)
        {
            return students.Where(s => s.Name.ToLower() == name.ToLower()).FirstOrDefault();
        }
    }
}
