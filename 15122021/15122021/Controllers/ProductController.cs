using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15122021.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Detail(int? id,string name,bool gender)
        {
            if (id == 0)
            {
                TempData["Name"] = name;
                return RedirectToAction("index");
            }

            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Gender = gender;
            return View();
        }
    }
}
