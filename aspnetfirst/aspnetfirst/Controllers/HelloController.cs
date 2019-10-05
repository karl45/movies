using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetfirst
{
    public class HelloController : Controller
    {
        // GET: /<controller>/


        public IActionResult Index()
        {

	    return View("Index");
        }
    }
}
