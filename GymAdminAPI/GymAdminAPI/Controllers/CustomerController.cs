using Microsoft.AspNetCore.Mvc;

namespace GymAdminAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        public IActionResult Get()
        {
            return View();
        }
    }
}
