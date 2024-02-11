using Microsoft.AspNetCore.Mvc;

namespace ClothifyPOS.Web.Areas.Products.Controllers
{
	[Area("Products")]
	public class ClothesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
