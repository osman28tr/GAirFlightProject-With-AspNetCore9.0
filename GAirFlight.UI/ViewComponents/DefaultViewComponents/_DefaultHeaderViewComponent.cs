using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.ViewComponents.DefaultViewComponents
{
	public class _DefaultHeaderViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
