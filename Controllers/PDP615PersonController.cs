using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PDPBaiThiLai.Models;

namespace PDPBaiThiLai.Controllers;

public class PDP516PersonController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(PDP516Person ps)
        {
            string strOutput = "Xin chao " + ps.PersonID + "-" + ps.Age + "-" + ps.Address;
            ViewBag.Message = strOutput;
            return View();
        }


    
}
