using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents; // ViewComponent için gerekli namespace

namespace AcunMedya.Cafe.ViewComponents
{
	public class _DefaultHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
