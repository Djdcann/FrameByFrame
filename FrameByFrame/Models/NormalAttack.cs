using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class Normal : Action
    {
        public Normal(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Normal)
        {

        }
    }

    public class Smash : Action
    {
        public int ChargeFrame { get; set; }
        public Smash(string Name, int Total, int[] StateChange, int FAF, int ChargeFrame) : base(Name, Total, StateChange, FAF, ActionType.Smash)
        {
            this.ChargeFrame = ChargeFrame;
        }
    }

    public class Aerial : Action
    {
        public int LandLag { get; set; }
        public int[] CancelRange { get; set; }
        public Aerial(string Name, int Total, int[] StateChange, int FAF, int LandLag, int[] CancelRange) : base(Name, Total, StateChange, FAF, ActionType.Aerial)
        {
            this.LandLag = LandLag;
            this.CancelRange = CancelRange;
        }
    }

    public class Special : Action
    {
        public Special(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Special)
        {

        }
    }

    public class Grab : Action
    {
        public Grab(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Grab)
        {

        }
    }

    public class Evasive : Action
    {
        public Evasive(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Evasive)
        {

        }
    }
}
