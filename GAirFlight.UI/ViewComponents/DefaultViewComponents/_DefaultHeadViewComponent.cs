using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.ViewComponents.DefaultViewComponents
{
	public class _DefaultHeadViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
