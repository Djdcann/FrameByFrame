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
            Character c = new Character(3, "Falco", "falco.png");
            c.Actions = new List<FrameByFrame.Models.Action>();
            c.Actions.Add(new NormalAttack("U-tilt", new int[] { 5, 12 }, 23, 23));
            c.Actions.Add(new NormalAttack("F-tilt", new int[] { 5, 10 }, 26, 27));
            c.Actions.Add(new NormalAttack("D-tilt", new int[] { 7, 10 }, 29, 28));
            c.Actions.Add(new NormalAttack("Dash Attack", new int[] { 4, 18 }, 39, 36));
            c.Actions.Add(new SmashAttack("U-smash", new int[] { 4, 12 }, 24, 25, 4));
            return View(c);
        }

        public IActionResult Character(string id)
        {
            
            return View();
        }
    }
}