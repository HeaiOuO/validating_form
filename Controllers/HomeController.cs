using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validating_Form.Models;

namespace Validating_Form.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // [Route("result")]
        // [HttpGet]
        [HttpPost("results")]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                return View("Results", newUser);
            }
            return View("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
