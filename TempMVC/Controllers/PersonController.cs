using Microsoft.AspNetCore.MVC;
namespace TempMVC.Controllers;
public class PersonController : Controllers
{
    public IActionResult Index()
    {
        return View()
    }
     public IActionResult Create()
    {
        return View()
    }
    [HttpPost]
    public IActionResult Create(Person ps)
    {
        ViewBag.mg = ps.PersonID + " - " + ps.FName;
        return View();
    }

}