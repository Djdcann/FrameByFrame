using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrameByFrame.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrameByFrame.Controllers
{
    [Route("api/[controller]")]
    public class FrameDataController : ControllerBase
    {
        public static Character[] roster = new Character[] {
            Character.fromID(Roster.DR_MARIO),
            Character.fromID(Roster.MARIO),
            Character.fromID(Roster.LUIGI),
            Character.fromID(Roster.BOWSER),
            Character.fromID(Roster.PEACH),
            Character.fromID(Roster.YOSHI),
            Character.fromID(Roster.DONKEY_KONG),
            Character.fromID(Roster.CAPTAIN_FALCON),
            Character.fromID(Roster.GANONDORF),
            Character.fromID(Roster.FALCO),
            Character.fromID(Roster.FOX),
            Character.fromID(Roster.NESS),
            Character.fromID(Roster.ICE_CLIMBERS),
            Character.fromID(Roster.KIRBY),
            Character.fromID(Roster.SAMUS),
            Character.fromID(Roster.ZELDA),
            Character.fromID(Roster.SHEIK),
            Character.fromID(Roster.LINK),
            Character.fromID(Roster.YOUNG_LINK),
            Character.fromID(Roster.PICHU),
            Character.fromID(Roster.PIKACHU),
            Character.fromID(Roster.JIGGLYPUFF),
            Character.fromID(Roster.MEWTWO),
            Character.fromID(Roster.MR_GAME_AND_WATCH),
            Character.fromID(Roster.MARTH),
            Character.fromID(Roster.ROY)
        };
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return roster;
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public Character Get(int id)
        //{
        //    return roster[id];
        //}

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Character Get(string id)
        {
            Roster ID = (Roster)Enum.Parse(typeof(Roster), id.ToUpper());
            return roster[(int)ID];
        }
    }
}
