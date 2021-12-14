using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using formsandprocessing.Model;

namespace formsandprocessing.Pages
{
    public class IndexModel : PageModel
    {
        [FromForm]
        public data data { get; set; }
        public void OnGet()
        {
            if (ModelState.IsValid)
            {
                DateTime answer = data.Adddate.AddDays(data.Days);

            }
        }




    }
}
