using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using Group = System.Text.RegularExpressions.Group;

namespace WebApi.Controllers
{
    public class StudentController : ApiController
    {
        List<Models.Group> groups = new List<Models.Group>()
        {
            new Models.Group()
            {
                GroupId = 1,
                NumberOfGroup = 10702216,
                Students = new List<Student>()
                {
                    new Student()
                    {
                        StudentId = 1,
                        Name = "Ivan",
                        Surname = "Menshov"
                    }
                }
            },

            new Models.Group()
            {
                GroupId = 2,
                NumberOfGroup = 123,
                Students = new List<Student>()
                {
                    new Student()
                    {
                        StudentId = 2,
                        Name = "Kirill",
                        Surname = "Vinokurov"
                    }
                }
            },

            new Models.Group()
            {
                GroupId = 3,
                NumberOfGroup = 321,
                Students = new List<Student>()
                {
                    new Student()
                    {
                        StudentId = 3,
                        Name = "Vadim",
                        Surname = "Belyashin"
                    }
                }
            },

            new Models.Group()
            {
                GroupId = 4,
                NumberOfGroup = 452,
                Students = new List<Student>()
                {
                    new Student()
                    {
                        StudentId = 4,
                        Name = "Sergei",
                        Surname = "Glushakov"
                    }
                }
            }
        };

        [HttpGet]
        public IEnumerable<Models.Group> GetAllGroup()
        {
            return groups;
        }

        [HttpGet]
        public IHttpActionResult GetGroupById(int id)
        {
            var groupOfId = groups.FirstOrDefault(_ => _.GroupId == id);

            if (groupOfId == null)
            {
                return NotFound();
            }

            return Ok(groupOfId);
        }

        [HttpPost]
        public IHttpActionResult PostGroup(int id, int group)
        {
            groups.Add(new Models.Group()
            {
                GroupId = id,
                NumberOfGroup = group,
                Students = null
            });

            return Ok(groups);
        }

        [HttpDelete]
        public IHttpActionResult DeleteGroup(int id)
        {
            groups.Remove(groups.FirstOrDefault(_ => _.GroupId == id));

            return Ok(groups);
        }
    }
}
