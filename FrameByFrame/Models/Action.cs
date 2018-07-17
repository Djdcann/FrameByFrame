using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public abstract class Action
    {
        public ActionType Type { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
        public int[] StateChange { get; set; }
        public int FAF { get; set; }

        private int characterID;
        protected static readonly int dropShield = 15;
        protected static readonly int dropShieldPerfect = 1;

        public Action(string Name, int Total, int[] StateChange, int FAF, ActionType Type)
        {
            this.Type = Type;
            this.Name = Name;
            this.Total = Total;
            this.StateChange = StateChange;
            this.FAF = FAF;
        }

        public virtual int getStartup(int Jumpsquat, bool perfectShield=false)
        {
            return StateChange[0];
        }

        public virtual int getEndlag()
        {
            return FAF - StateChange[StateChange.Length - 1];
        }
    }

    

    public enum ActionType
    {
        Normal,
        Smash,
        Aerial,
        Special,
        Grab,
        Throw,
        Evasive,
        Jab
    }
}
