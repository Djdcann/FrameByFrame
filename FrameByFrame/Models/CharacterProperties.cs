using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class CharacterProperties
    {
        public int Jumpsquat { get; set; }
        public int Dash { get; set; }
        public int Landlag { get; set; }
        public int SHAirtime { get; set; }
        public int FHAirtime { get; set; }
        public int AirJumps { get; set; }
        public int Taunt { get; set; }

        public CharacterProperties()
        {
            Jumpsquat = 3;
            Dash = 0;
            Landlag = 0;
            SHAirtime = 1;
            FHAirtime = 2;
            AirJumps = 1;
            Taunt = 0;
        }
    }

    public enum Roster
    {
        Dr_Mario,
        Mario,
        Luigi,
        Bowser,
        Peach,
        Yoshi,
        Donkey_Kong,
        Captain_Falcon,
        Ganondorf,
        Falco,
        Fox,
        Ness,
        Ice_Climbers,
        Kirby,
        Samus,
        Zelda,
        Sheik,
        Link,
        Young_Link,
        Pichu,
        Pikachu,
        JigglyPuff,
        Mewtwo,
        Mr_Game_and_Watch,
        Marth,
        Roy
    }
}
