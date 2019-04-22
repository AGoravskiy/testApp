using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TestTask.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        IFileService FileService { get; }
        public HomeController(IFileService fileService)
        {
            FileService = fileService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                String xml;
               using (var reader = new StreamReader(uploadedFile.OpenReadStream()))
                {
                    xml = reader.ReadToEnd();
                }
                FileService.Parse(xml);
            }
            return RedirectToAction("Index");
        }
    }
}
