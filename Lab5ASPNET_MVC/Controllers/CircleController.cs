using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingLab1Library;

namespace Lab5ASPNET_MVC.Controllers
{
    public class CircleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculate(string radius, string name, string surface, string perimeter)
        {
            int local_radius = int.Parse(radius);
            Circle local_circle;
            try 
            { 
                local_circle = new Circle(local_radius);
            }
            catch
            {
                ViewBag.Message = "Невозможный круг";
                return View("Index");
            }
            name = local_circle.getName();
            surface = local_circle.Surface().ToString();
            perimeter = local_circle.Perimeter().ToString();
            ViewBag.name = name;
            ViewBag.surface = surface;
            ViewBag.perimeter = perimeter;
            return View("Index");
        }
    }
}
