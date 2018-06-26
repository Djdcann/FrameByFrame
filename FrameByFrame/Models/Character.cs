using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class Character
    {
        int ID;
        string Name;
        string imageFile;
        object Properties { get; set; }
        List<Action> Actions { get; set; }
    }
}
