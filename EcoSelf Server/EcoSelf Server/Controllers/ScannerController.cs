using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcoSelf_Server.Controllers
{
    public class ScannerController : Controller
    {

        public IActionResult GetBarCode(int id)
        {
           return Content(User.Identity.Name);
        }

        public JsonResult SendNudes(int id)
        {
            string name = "[eq {id}"+ id;
            return Json(name) ;
        }



    }
}