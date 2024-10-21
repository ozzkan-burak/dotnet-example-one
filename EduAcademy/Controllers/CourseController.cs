using EduAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduAcademy.Controllers
{
  public class CourseController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Apply()
    {
      return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Apply(Candidates model)
    {
      Repository.Add(model);
      return Redirect("/");
    }
  }
}