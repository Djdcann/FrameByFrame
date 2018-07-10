using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class NormalAttack : Action
    {
        public NormalAttack(string Name, int[] StateChange, int Total, int FAF) : base(Name, StateChange, Total, FAF, ActionType.Normal)
        {

        }
    }

    public class SmashAttack : Action
    {
        public int ChargeFrame { get; set; }
        public SmashAttack(string Name, int[] StateChange, int Total, int FAF, int ChargeFrame) : base(Name, StateChange, Total, FAF, ActionType.Smash)
        {
            this.ChargeFrame = ChargeFrame;
        }
    }

    public class AerialAttack : Action
    {
        public int LandLag { get; set; }
        public int CancelFloor { get; set; }
        public int CancelCeil { get; set; }
        public AerialAttack(string Name, int[] StateChange, int Total, int FAF, int LandLag) : base(Name, StateChange, Total, FAF, ActionType.Aerial)
        {
            this.LandLag = LandLag;
        }
    }

    public class Grab : Action
    {
        public Grab(string Name, int[] StateChange, int Total, int FAF) : base(Name, StateChange, Total, FAF, ActionType.Grab)
        {

        }
    }
}
