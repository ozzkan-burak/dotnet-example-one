using EduAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduAcademy.Controllers
{
  public class CourseController : Controller
  {
    public IActionResult Index()
    {
      var model = Repository.Applications;
      return View(model);
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
      return View("Feedback", model);
    }
  }
}