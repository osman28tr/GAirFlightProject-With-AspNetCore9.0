using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("/Admin/Flight/List")]
	public class FlightController : Controller
	{
		[HttpGet("/Admin/Flight/List")]
		public IActionResult List()
		{
			return View();
		}
		[HttpGet("/Admin/Flight/Create")]
		public IActionResult Create() { return View(); }
	}
}
