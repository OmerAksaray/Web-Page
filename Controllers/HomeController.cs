using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using review.Models;

namespace review.Controllers;

public class HomeController : Controller
{
   public IActionResult Index(){

return View(Repoistory.Courses);

}

    public IActionResult Contact(){

return View();

}

    
}
