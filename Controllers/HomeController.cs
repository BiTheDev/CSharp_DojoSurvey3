using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey3.Models;

namespace DojoSurvey3.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]       
        [Route("")]     
        public IActionResult Index()
        {
            return View("index");    
        }

        [HttpPost("process")]
        public IActionResult Process(Dojo result){
            if(ModelState.IsValid){
                return View("created", result);
            }else{
                return View("index");
            }
        }
    }
}
