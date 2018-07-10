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
            Character c = new Character(3, "Falco", "/images/portraits/falco.png");
            c.Actions = new List<FrameByFrame.Models.Action>();
            c.Actions.Add(new NormalAttack("U-tilt", new int[] { 4, 12 }, 24, 25));
            return View(c);
        }

        public IActionResult Character(string id)
        {
            
            return View();
        }
    }
}