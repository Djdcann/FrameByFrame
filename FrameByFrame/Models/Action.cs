using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public abstract class Action
    {
        string Name { get; set; }
        ActionType type { get; set; }
        int[] StateChange { get; set; }
        int Total { get; set; }
        int FAF { get; set; }
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
