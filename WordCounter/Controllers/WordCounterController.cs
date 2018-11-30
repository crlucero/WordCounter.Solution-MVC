using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class RepeatCounterController : Controller
    {
        [HttpGet("/game")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/result")]
        public ActionResult Result()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);

            return View("result", newRepeatCounter);
        }
    }
}