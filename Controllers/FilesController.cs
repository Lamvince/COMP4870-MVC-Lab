using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles("TextFiles").Select(file => Path.GetFileName(file)).ToArray();
            Array.Sort(files);
            ViewData["files"] = files;
            return View();
        }

        public ActionResult Content(int id)
        {
            string[] files = Directory.GetFiles("TextFiles");
            Array.Sort(files);
            ViewData["file"] = System.IO.File.ReadAllText(files[id - 1]);
            return View();
        }
    }
}