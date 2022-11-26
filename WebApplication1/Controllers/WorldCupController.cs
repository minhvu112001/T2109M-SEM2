using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Demo1.Controllers
{
    public class WorldCup : Controller
    {
        public string Welcome2(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Team {name}, NumTimes is: {numTimes}");
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TeamFootball(string name, int numTimes = 12)
        {
            ViewData["Message"] = "Team " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
