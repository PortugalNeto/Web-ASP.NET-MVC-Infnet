using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_MVC.Controllers
{
    public class AmigoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
