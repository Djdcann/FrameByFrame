using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrameByFrame.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrameByFrame.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index(string id)
        {
            //Character c = new Character(9, "Falco", "falco.png");
            //c.TiltU = new Normal("U-tilt",        23, new int[2] { 5, 12 },   23);
            //c.TiltF = new Normal("F-tilt",        26, new int[2] { 5, 10 },   27);
            //c.TiltD = new Normal("D-tilt",        29, new int[2] { 7, 10 },   28);

            //c.DashA = new Normal("Dash Attack",   39, new int[2] { 4, 18 },   36);

            //c.SmashU = new Smash("U-smash",        43, new int[2] { 7, 16 },   44, 2);
            //c.SmashF = new Smash("F-smash",        39, new int[2] { 12, 22 },  40, 7);
            //c.SmashD = new Smash("D-smash",        49, new int[2] { 6, 11 },   46, 2);

            //c.AerialU = new Aerial("U-air",         39, new int[4] { 8, 10, 11, 15 },   36, 18, new int[2] { 7, 26 });
            //c.AerialF = new Aerial("F-air",         59, new int[10] { 6, 9, 16, 19, 24, 27, 33, 36, 43, 46 },   53, 22, new int[2] { 5, 49 });
            //c.AerialD = new Aerial("D-air",         49, new int[2] { 5, 25 },   50, 18, new int[2] { 4, 30 });
            //c.AerialB = new Aerial("B-air",         39, new int[2] { 4, 20 },   38, 20, new int[2] { 3, 23 });
            //c.AerialN = new Aerial("N-air",         49, new int[2] { 4, 32 },   42, 15, new int[2] { 3, 37 });

            //c.Grab = new Grab("Standing Grab", 30, new int[2] { 7, 9 }, 31);
            //c.GrabD = new Grab("Dash Grab", 40, new int[2] { 12, 14 }, 41, true);

            //c.Jabs.Add(new Jab("Jab1", 17, new int[2] { 2, 4 }, 16, 6, 31));
            //c.Jabs.Add(new Jab("Jab2", 20, new int[2] { 3, 5 }, 19, 7, 20));
            //c.Jabs.Add(new Jab("Jab3", 59, new int[12] { 3, 5, 10, 12, 17, 19, 24, 26, 31, 33, 39, 41 }, 50));

            //c.Specials.Add(new Special("Ground Laser", 57, new int[2] { 23, 47 }, 58));
            //c.Specials.Add(new Special("Air Laser", 42, new int[2] { 13, 29 }, 43));
            //c.Specials.Add(new Special("Phantasm", 59, new int[2] { 18, 22 }, 60));
            //c.Specials.Add(new Special("Firebird", 84, new int[2] { 43, 65 }, 85));
            //c.Specials.Add(new Special("Shine", 39, new int[2] { 1, 2 }, 4));

            //c.Airdodge = new Evasive("Airdodge", 49, new int[2] { 4, 30 }, 50);
            //c.Spotdodge = new Evasive("Spotdodge", 22, new int[2] { 2, 16 }, 23);
            //c.RollF = new Evasive("F-Roll", 31, new int[2] { 4, 20 }, 32);
            //c.RollB = new Evasive("B-Roll", 31, new int[2] { 4, 20 }, 32);

            //c.Attributes = new CharacterProperties { Jumpsquat = 4, Dash = 11, SHAirtime = 25, FHAirtime = 51, Landlag = 4, AirJumps = 1, Taunt = 114 };
            Roster ID = (Roster)Enum.Parse(typeof(Roster), id.ToUpper());
            
            return View(FrameDataController.roster[(int)ID]);
        }

        public IActionResult Matchup(string id, string id2)
        {
            Roster ID = (Roster)Enum.Parse(typeof(Roster), id.ToUpper());
            Roster ID2 = (Roster)Enum.Parse(typeof(Roster), id2.ToUpper());
            return View(new Character[]{ FrameDataController.roster[(int)ID], FrameDataController.roster[(int)ID2] });
        }
    }
}