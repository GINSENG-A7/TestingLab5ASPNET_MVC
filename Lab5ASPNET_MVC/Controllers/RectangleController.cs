using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingLab1Library;

namespace Lab5ASPNET_MVC.Controllers
{
    public class RectangleController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Calculate(string height, string width, string name, string surface, string perimeter)
        {
            int local_height = int.Parse(height);
            int local_width = int.Parse(width);
            Rectangle local_rectangle; 
            try
            {
                local_rectangle = new Rectangle(local_height, local_width);
            }
            catch
            {
                ViewBag.Message = "Невозможный прямоугольник";
                return View("Index");
            }
            name = local_rectangle.getName();
            surface = local_rectangle.Surface().ToString();
            perimeter = local_rectangle.Perimeter().ToString();
            ViewBag.name = name;
            ViewBag.surface = surface;
            ViewBag.perimeter = perimeter;
            return View("Index");
        }
    }
}
