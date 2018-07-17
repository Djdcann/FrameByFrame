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
        DR_MARIO,
        MARIO,
        LUIGI,
        BOWSER,
        PEACH,
        YOSHI,
        DONKEY_KONG,
        CAPTAIN_FALCON,
        GANONDORF,
        FALCO,
        FOX,
        NESS,
        ICE_CLIMBERS,
        KIRBY,
        SAMUS,
        ZELDA,
        SHEIK,
        LINK,
        YOUNG_LINK,
        PICHU,
        PIKACHU,
        JIGGLYPUFF,
        MEWTWO,
        MR_GAME_AND_WATCH,
        MARTH,
        ROY
    }
}
