using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.Areas.Admin.ViewComponents
{
	public class _AdminSidebarViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
