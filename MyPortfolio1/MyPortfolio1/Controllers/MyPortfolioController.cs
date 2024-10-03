using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.Controllers
{
	public class MyPortfolioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
