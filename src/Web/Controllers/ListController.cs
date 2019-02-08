using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace dotnet_mvc.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowText()
        {
            return Content("Click back to return to the previous page.");
        }
        public IActionResult ShowJSON()
        {
            return Json(new { name = "favorite name list", quote = "This is my favorite name list." });
        }
        public IActionResult ShowHTML()
        {
            var h = "<!DOCTYPE html><html><body>An awesome name list" +
            "<br><br> <a href='/Quote'>Go Back to List</a></body></html>";
            return Content(h, "text/html");
        }

        public IActionResult ShowView()
        {
            return View();
        }

     
    }
}