using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using People.Business.Interfaces;
using People.Domain.Entities;
using People.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace People.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonBO _personBO;

        public HomeController(
            ILogger<HomeController> logger,
            IPersonBO personBO)
        {
            _logger = logger;
            _personBO = personBO;
        }

        public IActionResult Index(string documentNumber = null)
        {
            List<Person> list = _personBO.GetAllByDocumentNumber(documentNumber);

            return View(list);
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
