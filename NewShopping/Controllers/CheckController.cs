using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ZNewShopping.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Check()
        {
           
            return View();
        }
    }
}
