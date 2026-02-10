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
            ViewData["Title"]="Ana Sayfa";
            ViewData["Ad"]="Arda Yalcin";
            ViewBag.Bolum="Bilişim Teknolojileri";
            //TempData["Mesaj"]="İşlem Tamamlandı";
            //return RedirectToAction("Privacy","Home"); 
            return View();
        }
        public IActionResult Index2()
        {
            List<string> Images=new List<string>();
            Images.Add("agac.webp");
            Images.Add("araba.jpg");
            Images.Add("manzara1.jpg");
            Images.Add("manzara2.jpg");

            return View(Images);
        }
        public IActionResult Goster()
        {
            ViewData["Title"]="Ana Sayfa1";
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
            //return NotFound(); //Sayfa Bulunamadı hatası verir eror404
            //return Unauthorized(); //Yetkisiz giriş eror401
        }
    }
}