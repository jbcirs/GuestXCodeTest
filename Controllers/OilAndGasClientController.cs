using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GuestXCodingTest.Controllers
{
    public class OilAndGasClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}