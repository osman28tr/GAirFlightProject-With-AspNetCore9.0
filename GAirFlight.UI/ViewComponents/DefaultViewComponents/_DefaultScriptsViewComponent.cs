using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.ViewComponents.DefaultViewComponents
{
	public class _DefaultScriptsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() => View();
	}
}
