using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.ViewComponents.DefaultViewComponents
{
	public class TestDenemePartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
