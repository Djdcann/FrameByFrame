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
        public int[] StateChange { get; set; }
        public int Total { get; set; }
        public int FAF { get; set; }

        public Action(string Name,  int[] StateChange, int Total, int FAF, ActionType Type)
        {
            this.Name = Name;
            this.Type = Type;
            this.StateChange = StateChange;
            this.Total = Total;
            this.FAF = FAF;
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
        Evasive
    }
}
