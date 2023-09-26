using System.Dynamic;
using System;
using Microsoft.AspNetCore.mvc;
namespace TempMVC.Controllers;
public class Tinhluong : Controllers
{
    public IActionResult Tinhluong()
    {
        return View();
    }
    [HttpPost]
    public IactionResult Tinhluog(string Luongcb, string heso, string Phucap)
    {
        double Lcb =0, hs =0, pc =0, ; Luongcb = 0;
        string trave;
        if(!String.IsNullOrEmpty(Luongcb)) Lcb = Convert.ToDouble(LuongCb);
        if(!String.IsNullOrEmpty(heso)) hs = Convert.ToDouble(heso);
        if(!String.IsNullOrEmpty(Phucap)) pc = Convert.ToDouble(Phucap);
        luong = lcb*hs+pc;
        trave = "Lương của bạn là: " + luong;
        ViewBag.tl = trave;
        return View();
    }
}