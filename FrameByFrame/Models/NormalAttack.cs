﻿using System;
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

        public override int getStartup(int Jumpsquat, bool perfectShield = false)
        {
            int a = Name == "Dash Attack" ? 4 : 0; //Additional startup frames for dash attack
            if (perfectShield)
            {
                return a + dropShieldPerfect + StateChange[0];
            }
            else
            {
                return a + dropShield + StateChange[0];
            }
        }
    }

    public class Jab : Action
    {
        public int NextStart { get; set; }
        public int NextWindow { get; set; }
        public bool IsLoop { get; set; }
        public Jab(string Name, int Total, int[] StateChange, int FAF, int NextStart=0, int NextWindow=0, bool IsLoop=false) : base(Name, Total, StateChange, FAF, ActionType.Jab)
        {
            this.NextStart = NextStart;
            this.NextWindow = NextWindow;
            this.IsLoop = IsLoop;
        }

        public override int getStartup(int Jumpsquat, bool perfectShield = false)
        {
            if (perfectShield)
            {
                return dropShieldPerfect + StateChange[0];
            }
            else
            {
                return dropShield + StateChange[0];
            }
        }
    }

    public class Smash : Action
    {
        public int ChargeFrame { get; set; }
        public Smash(string Name, int Total, int[] StateChange, int FAF, int ChargeFrame) : base(Name, Total, StateChange, FAF, ActionType.Smash)
        {
            this.ChargeFrame = ChargeFrame;
        }

        public override int getStartup(int Jumpsquat, bool perfectShield = false)
        {
            if (perfectShield)
            {
                return dropShieldPerfect + StateChange[0];
            }
            else
            {
                return dropShield + StateChange[0];
            }
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

        public override int getStartup(int Jumpsquat, bool perfectShield = false)
        {
            return Jumpsquat + StateChange[0];
        }

        public override int getEndlag()
        {
            return this.LandLag /2;
        }
    }

    public class Special : Action
    {
        public Special(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Special)
        {

        }

        public override int getStartup(int Jumpsquat, bool perfectShield = false)
        {
            if (perfectShield)
            {
                return dropShieldPerfect + StateChange[0];
            }
            else
            {
                return Jumpsquat + StateChange[0];
            }
        }
    }

    public class Grab : Action
    {
        public bool IsDash { get; set; }
        public Grab(string Name, int Total, int[] StateChange, int FAF, bool IsDash=false) : base(Name, Total, StateChange, FAF, ActionType.Grab)
        {
            this.IsDash = IsDash;
            activeClass = "grab";
        }
    }

    public class Evasive : Action
    {
        public Evasive(string Name, int Total, int[] StateChange, int FAF) : base(Name, Total, StateChange, FAF, ActionType.Evasive)
        {
            activeClass = "invincible";
        }
    }
}
