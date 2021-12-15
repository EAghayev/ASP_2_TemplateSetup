using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ViewModels
{
    public class HomeViewModel
    {
        public List<Student> Students { get; set; }
        public List<Group> Groups { get; set; }
        public List<Faculty> Faculties { get; set; } = new List<Faculty>();
    }
}
