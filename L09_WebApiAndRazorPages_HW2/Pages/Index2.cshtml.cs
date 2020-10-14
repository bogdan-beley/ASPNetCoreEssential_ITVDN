using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace L09_WebApiAndRazorPages_HW2.Pages
{
    public class Index2Model : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
