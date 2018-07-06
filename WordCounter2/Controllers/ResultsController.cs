using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter2.Controllers
{
    public class ResultsController : Controller
    {
        [HttpGet("/results")]
        public ActionResult Results()
        {
            RepeatCounter newCount = new RepeatCounter();
            return View(newCount);
        }
    }
}