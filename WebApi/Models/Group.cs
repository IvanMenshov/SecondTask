using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public int NumberOfGroup { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}