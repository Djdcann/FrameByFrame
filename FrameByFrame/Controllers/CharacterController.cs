using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrameByFrame.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}