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
            Character.fromID(Roster.Dr_Mario),
            Character.fromID(Roster.Mario),
            Character.fromID(Roster.Luigi),
            Character.fromID(Roster.Bowser),
            Character.fromID(Roster.Peach),
            Character.fromID(Roster.Yoshi),
            Character.fromID(Roster.Donkey_Kong),
            Character.fromID(Roster.Captain_Falcon),
            Character.fromID(Roster.Ganondorf),
            Character.fromID(Roster.Falco),
            Character.fromID(Roster.Fox),
            Character.fromID(Roster.Ness),
            Character.fromID(Roster.Ice_Climbers),
            Character.fromID(Roster.Kirby),
            Character.fromID(Roster.Samus),
            Character.fromID(Roster.Zelda),
            Character.fromID(Roster.Sheik),
            Character.fromID(Roster.Link),
            Character.fromID(Roster.Young_Link),
            Character.fromID(Roster.Pichu),
            Character.fromID(Roster.Pikachu),
            Character.fromID(Roster.JigglyPuff),
            Character.fromID(Roster.Mewtwo),
            Character.fromID(Roster.Mr_Game_and_Watch),
            Character.fromID(Roster.Marth),
            Character.fromID(Roster.Roy)
        };
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return roster;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Character Get(int id)
        {
            return roster[id];
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
