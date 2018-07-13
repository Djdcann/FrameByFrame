using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrameByFrame.Models;

namespace FrameByFrame.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            List<Character> roster = new List<Character>();
            roster.Add(new Character(0,  "Dr. Mario",      "dr_mario.png"));
            roster.Add(new Character(1,  "Mario",          ""));
            roster.Add(new Character(2,  "Luigi",          ""));
            roster.Add(new Character(3,  "Bowser",         ""));
            roster.Add(new Character(4,  "Peach",          ""));
            roster.Add(new Character(5,  "Yoshi",          ""));
            roster.Add(new Character(6,  "Donkey Kong",    ""));
            roster.Add(new Character(7,  "Captain Falcon", ""));
            roster.Add(new Character(8,  "Ganondorf",      ""));
            roster.Add(new Character(9,  "Falco",          ""));
            roster.Add(new Character(10, "Fox",            ""));
            roster.Add(new Character(11, "Ness",           ""));
            roster.Add(new Character(12, "Iceys",          ""));
            roster.Add(new Character(13, "Kirby",          ""));
            roster.Add(new Character(14, "Samus",          ""));
            roster.Add(new Character(15, "Zelda",          ""));
            roster.Add(new Character(16, "Sheik",          ""));
            roster.Add(new Character(17, "Link",           ""));
            roster.Add(new Character(18, "Young Link",     ""));
            roster.Add(new Character(19, "Pichu",          ""));
            roster.Add(new Character(20, "Pikachu",        ""));
            roster.Add(new Character(21, "Jigglypuff",     ""));
            roster.Add(new Character(22, "Mewtwo",         ""));
            roster.Add(new Character(23, "Mr. GnW",        ""));
            roster.Add(new Character(24, "Marth",          ""));
            roster.Add(new Character(25, "Roy",            ""));
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
