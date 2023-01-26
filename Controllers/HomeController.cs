using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetWork_Food.DB_NetWork_Food;
using NetWork_Food.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetWork_Food.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NetWork_Food_DBContext _dbContext;

        public HomeController(ILogger<HomeController> logger, NetWork_Food_DBContext dbContext)
        {
            _logger = logger;
            _dbContext= dbContext;
        }

        public IActionResult Index()
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
