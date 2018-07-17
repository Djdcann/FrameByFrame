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
            roster.Add(new Character(Roster.Dr_Mario, "Dr. Mario"));
            roster.Add(new Character(Roster.Mario, "Mario"));
            roster.Add(new Character(Roster.Luigi, "Luigi"));
            roster.Add(new Character(Roster.Bowser, "Bowser"));
            roster.Add(new Character(Roster.Peach, "Peach"));
            roster.Add(new Character(Roster.Yoshi, "Yoshi"));
            roster.Add(new Character(Roster.Donkey_Kong, "Donkey Kong"));
            roster.Add(new Character(Roster.Captain_Falcon, "Captain Falcon"));
            roster.Add(new Character(Roster.Ganondorf, "Ganondorf"));
            roster.Add(new Character(Roster.Falco, "Falco"));
            roster.Add(new Character(Roster.Fox, "Fox"));
            roster.Add(new Character(Roster.Ness, "Ness"));
            roster.Add(new Character(Roster.Ice_Climbers, "Iceys"));
            roster.Add(new Character(Roster.Kirby, "Kirby"));
            roster.Add(new Character(Roster.Samus, "Samus"));
            roster.Add(new Character(Roster.Zelda, "Zelda"));
            roster.Add(new Character(Roster.Sheik, "Sheik"));
            roster.Add(new Character(Roster.Link, "Link"));
            roster.Add(new Character(Roster.Young_Link, "Young Link"));
            roster.Add(new Character(Roster.Pichu, "Pichu"));
            roster.Add(new Character(Roster.Pikachu, "Pikachu"));
            roster.Add(new Character(Roster.JigglyPuff, "Jigglypuff"));
            roster.Add(new Character(Roster.Mewtwo, "Mewtwo"));
            roster.Add(new Character(Roster.Mr_Game_and_Watch, "Mr. GnW"));
            roster.Add(new Character(Roster.Marth, "Marth"));
            roster.Add(new Character(Roster.Roy, "Roy"));
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
