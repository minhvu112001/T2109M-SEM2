using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class WorldCup : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            if (id == 1)
            {
                ViewData["name1"] = "Anh";
                ViewData["img1"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/Anh.png";
                ViewData["name2"] = "Mỹ";
                ViewData["img2"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/My.png";
                ViewData["end"] = "0 - 0";
            }
            else if (id == 2)
            {
                ViewData["name1"] = "Qatar";
                ViewData["img1"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/Qatar.png";
                ViewData["name2"] = "Senegal";
                ViewData["img2"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/Senegal.png";
                ViewData["end"] = "1 - 3";
            }
            else if (id == 3)
            {
                ViewData["name1"] = "Iran";
                ViewData["img1"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/Iran.png";
                ViewData["name2"] = "Wales";
                ViewData["img2"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/Wales.png";
                ViewData["end"] = "2 - 0";
            }
            else if (id == 4)
            {
                ViewData["name1"] = "Han Quoc";
                ViewData["img1"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/SouthKorea.png";
                ViewData["name2"] = "Ghana";
                ViewData["img2"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/Ghana.png";
                ViewData["end"] = "2 - 3";
            }
            else
            {
                ViewData["name1"] = "Anh";
                ViewData["img1"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/Anh.png";
                ViewData["name2"] = "Mỹ";
                ViewData["img2"] = "https://s1.vnecdn.net/vnexpress/restruct/i/v681/flag/My.png";
                ViewData["end"] = "0 - 0";
            }
            //switch (id)
            //{
            //    case 1:

            //        break;

            //    case 2:

            //        break;
            //    default:

            //        break;
            //}

            return View();
        }

    }
}