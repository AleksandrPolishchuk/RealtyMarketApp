using Microsoft.AspNetCore.Mvc;

namespace RealtyMarketApp.Frontend.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
