using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;

namespace RecipeBox.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}