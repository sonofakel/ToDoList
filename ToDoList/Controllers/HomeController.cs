using System;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();

		}
    }
}
