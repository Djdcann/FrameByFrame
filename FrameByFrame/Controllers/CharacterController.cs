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
            return View();
        }

        public IActionResult Character(string id)
        {
            Character c = new Character(3, "Falco", "/images/portraits/falco.png");
            return View(c);
        }
    }
}