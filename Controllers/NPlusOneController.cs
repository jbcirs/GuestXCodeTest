using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestXCodingTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Text;

namespace GuestXCodingTest.Controllers
{
    public class NPlusOneController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var input = RandomList(10, 10).ToList();
            var output = input.GroupBy(x => x)
                        .Where(g => g.Count() > 1)
                        .Select(g => g.Key)
                        .OrderBy(o => true);

            var result = new NPlusOneViewModel()
            {
                InputValues = String.Join(",", input),
                OutputValues = String.Join(",", output)
            };
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetDuplicates(string numbers)
        {
            var input = numbers.Split(",").ToList();
            var output = input.GroupBy(x => x)
                       .Where(g => g.Count() > 1)
                       .Select(g => g.Key)
                       .OrderBy(o => true);

            var result = new NPlusOneViewModel()
            {
                InputValues = String.Join(",", input),
                OutputValues = String.Join(",", output)
            };
            return Json(result);
        }




        private IEnumerable<int> RandomList(int numOfInts, int maxValue)
        {
            Random r = new Random();
            return Enumerable.Range(0, numOfInts).Select(x => r.Next(maxValue + 1)).Take(10);
        }
    }
}