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
        public ActionResult Results(string word, string phrase)
        {
            RepeatCounter newCount = new RepeatCounter(word, phrase);
            return View(newCount);
        }

        [HttpPost("/results")]
        public ActionResult FilloutForm(string word, string phrase)
        {
            RepeatCounter newCount = new RepeatCounter(word, phrase);
            return View("Results", newCount);
        }
    }
}