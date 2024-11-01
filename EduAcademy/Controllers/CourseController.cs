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
      if(Repository.Applications.Any(c=> c.Email.Equals(model.Email))){
        ModelState.AddModelError("", "Bir kullanıcı sadece tek bir eğitime başvurabilir.");
      }
      if(ModelState.IsValid)
      {
        Repository.Add(model);
        return View("Feedback", model);
      }

      return View();
    }
  }
}