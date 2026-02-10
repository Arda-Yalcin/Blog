using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Goster()
        {
            return Content("Merhaba Dünya");
        }

        public IActionResult JsonDon()
        {
            return Json(new {succses=false,message="Islem Basarisiz"});
        }

        public IActionResult Yonlendir()
        {
            return Redirect("http://Google.com");
        }
        public IActionResult Yonlendir2()
        {
            return RedirectToAction("Index","Home");
        }
    }
}