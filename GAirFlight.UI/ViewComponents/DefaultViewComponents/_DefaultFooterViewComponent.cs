using Microsoft.AspNetCore.Mvc;

namespace GAirFlight.UI.ViewComponents.DefaultViewComponents
{
	public class _DefaultFooterViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() => View();
	}
}
