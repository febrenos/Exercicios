using Microsoft.AspNetCore.Mvc;
namespace McBonaldsMVC
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}