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
            roster.Add(new Character(Roster.DR_MARIO, "Dr. Mario"));
            roster.Add(new Character(Roster.MARIO, "Mario"));
            roster.Add(new Character(Roster.LUIGI, "Luigi"));
            roster.Add(new Character(Roster.BOWSER, "Bowser"));
            roster.Add(new Character(Roster.PEACH, "Peach"));
            roster.Add(new Character(Roster.YOSHI, "Yoshi"));
            roster.Add(new Character(Roster.DONKEY_KONG, "Donkey Kong"));
            roster.Add(new Character(Roster.CAPTAIN_FALCON, "Captain Falcon"));
            roster.Add(new Character(Roster.GANONDORF, "Ganondorf"));
            roster.Add(new Character(Roster.FALCO, "Falco"));
            roster.Add(new Character(Roster.FOX, "Fox"));
            roster.Add(new Character(Roster.NESS, "Ness"));
            roster.Add(new Character(Roster.ICE_CLIMBERS, "Iceys"));
            roster.Add(new Character(Roster.KIRBY, "Kirby"));
            roster.Add(new Character(Roster.SAMUS, "Samus"));
            roster.Add(new Character(Roster.ZELDA, "Zelda"));
            roster.Add(new Character(Roster.SHEIK, "Sheik"));
            roster.Add(new Character(Roster.LINK, "Link"));
            roster.Add(new Character(Roster.YOUNG_LINK, "Young Link"));
            roster.Add(new Character(Roster.PICHU, "Pichu"));
            roster.Add(new Character(Roster.PIKACHU, "Pikachu"));
            roster.Add(new Character(Roster.JIGGLYPUFF, "Jigglypuff"));
            roster.Add(new Character(Roster.MEWTWO, "Mewtwo"));
            roster.Add(new Character(Roster.MR_GAME_AND_WATCH, "Mr. GnW"));
            roster.Add(new Character(Roster.MARTH, "Marth"));
            roster.Add(new Character(Roster.ROY, "Roy"));
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
