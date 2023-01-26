using Microsoft.AspNetCore.Mvc;
using NetWork_Food.DB_NetWork_Food.Entities;
using NetWork_Food.Services;
using System.Linq;
using System.Threading.Tasks;

namespace NetWork_Food.Controllers
{
    [Controller]

    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly ServiceFood _service;

        public UserController(ServiceFood service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {

            await _service.Create(user);
            return View();
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return View(_service.GetList().ToList());
        }
    }
}
