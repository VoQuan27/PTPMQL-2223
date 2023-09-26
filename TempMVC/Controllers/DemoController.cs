using Microsoft.AspNetCore.MVC;
namespace TempMVC.Controllers;
public class DemoControler : Controllers
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fName)
    {
        ViewBag.mess = "Xin chao " + fName;
        return View()
    }
}