using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace L08_Controllers_HW2.Controllers
{
    public class FilesController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FilesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public VirtualFileResult GetExampleFile()
        {
            string filePath = Path.Combine("~/Files", "example.txt");

            return File(filePath, "Application/txt", "example.txt");
        }
    }
}
