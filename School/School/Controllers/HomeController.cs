using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Group> groups = new List<Group>
            {
                new Group{Id=45,Name = "P201"},
                new Group{Id=40,Name = "P202"},
                new Group{Id=41,Name = "P203"},
            };
            List<Student> students = new List<Student>
            {
                new Student{Id=34,Name = "Hikmet",Surname ="Abbasov",GroupNo = "P404",TotalPoint = 75},
                new Student{Id=35,Name = "Togrul",Surname ="Niva",GroupNo = "P201",TotalPoint = 55},
                new Student{Id=38,Name = "Elnur",Surname ="Akula",GroupNo = "P201",TotalPoint = 56},
                new Student{Id=45,Name = "Hesen",Surname ="Cayci",GroupNo = "P202",TotalPoint = 41},
            };

            List<Faculty> faculties = new List<Faculty>
            {
                new Faculty{Id = 10,Name = "IT",StudentCount=140},
                new Faculty{Id = 11,Name = "Economic",StudentCount=150},
                new Faculty{Id = 12,Name = "IKT",StudentCount=190}
            };

            HomeViewModel homeVM = new HomeViewModel
            {
                Students = students,
                Groups = groups,
            };



            //ViewBag.Students = model;
            return View(homeVM);
        }

        public IActionResult Group()
        {
            List<Group> groups = new List<Group>
            {
                new Group{Id=45,Name = "P201"},
                new Group{Id=40,Name = "P202"},
                new Group{Id=41,Name = "P203"},
            };
            return View(groups);
        }
    }
}
