using Microsoft.AspNetCore.Mvc;
using practice_task.DAL;
using practice_task.Models;
using System.Collections.Generic;
using System.Linq;

namespace practice_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = context.Sliders.ToList();
            return View(sliders);
        }
    }
}
