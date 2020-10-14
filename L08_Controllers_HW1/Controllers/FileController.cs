using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using L08_Controllers_HW1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;

namespace L08_Controllers_HW1.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(FileModel fileModel)
        {
            string fileName = fileModel.FileName + ".txt";
            string fileType = "Application/txt";
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string filePath = Path.Combine(contentRootPath, "Files/" + fileName);

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(fileModel.Fname + " " + fileModel.Lname);
            }

            return PhysicalFile(filePath, fileType, fileName);
        }
    }
}
