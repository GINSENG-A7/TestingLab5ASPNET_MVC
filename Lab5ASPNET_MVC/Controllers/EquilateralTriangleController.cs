using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingLab1Library;

namespace Lab5ASPNET_MVC.Controllers
{
    public class EquilateralTriangleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculate(string age, string name, string surface, string perimeter)
        {
            int local_age = int.Parse(age);
            EquilateralTriangle local_triangle;
            try
            {
                local_triangle = new EquilateralTriangle(local_age);
            }
            catch
            {
                ViewBag.Message = "Невозможный треугольник";
                return View("Index");
            }
            name = local_triangle.getName();
            surface = local_triangle.Surface().ToString();
            perimeter = local_triangle.Perimeter().ToString();
            ViewBag.name = name;
            ViewBag.surface = surface;
            ViewBag.perimeter = perimeter;
            return View("Index");
        }
    }
}
