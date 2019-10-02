using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviesHW.Pages
{
    public class IndexModel : PageModel
    {
        public string[] MyMovies { get; set; }
        
        public void OnGet()
        {
            MyMovies = new string[]
            {
                "Friday","Next Friday","Friday After Next"
            };
        }
    }
}
