using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class NormalAttack : Action
    {
        public NormalAttack(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Normal)
        {

        }
    }

    public class SmashAttack : Action
    {
        public int ChargeFrame { get; set; }
        public SmashAttack(string Name, int Total, int[] StateChange, int FAF, int ChargeFrame) : base(Name, Total, StateChange, FAF, ActionType.Smash)
        {
            this.ChargeFrame = ChargeFrame;
        }
    }

    public class AerialAttack : Action
    {
        public int LandLag { get; set; }
        public int[] CancelRange { get; set; }
        public AerialAttack(string Name, int Total, int[] StateChange, int FAF, int LandLag, int[] CancelRange) : base(Name, Total, StateChange, FAF, ActionType.Aerial)
        {
            this.LandLag = LandLag;
            this.CancelRange = CancelRange;
        }
    }

    public class SpecialAttack : Action
    {
        public SpecialAttack(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Special)
        {

        }
    }

    public class Grab : Action
    {
        public Grab(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Grab)
        {

        }
    }
}
