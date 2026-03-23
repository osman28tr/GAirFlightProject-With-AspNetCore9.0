using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.ViewComponents.DefaultViewComponents
{
	public class TestViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
