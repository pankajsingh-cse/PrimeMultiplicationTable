using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiplicationTablesForPrimeNumbers.Core;
using MultiplicationTablesForPrimeNumbers.Models;
using MultiplicationTablesForPrimeNumbers.UI.Models;

namespace MultiplicationTablesForPrimeNumbers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFirstNPrimes _firstNPrimes;
        private readonly IMultiplicationTable _multiplicationTable;

        public HomeController(ILogger<HomeController> logger, IFirstNPrimes firstNPrimes, IMultiplicationTable multiplicationTable)
        {
            _logger = logger;
            _firstNPrimes = firstNPrimes;
            _multiplicationTable = multiplicationTable;
        }

        public IActionResult Index(MultiplicationModel model)
        {
            if (ModelState.IsValid)
            {
                var primes = _firstNPrimes.GetPrimes(model.InputNumber);
                var multiplicationTable = _multiplicationTable.GetTable(primes);
                ViewBag.InputNumber = model.InputNumber;
                ViewBag.PrimeNumbers = primes;
                ViewBag.Table = multiplicationTable;
            }

            return View("Index", model);
        }

        //[HttpPost]
        //public ActionResult PrimeMultiply(MultiplicationModel model)
        //{
        //}

        public IActionResult DevNotes()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
