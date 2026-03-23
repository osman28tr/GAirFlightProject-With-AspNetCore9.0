using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
