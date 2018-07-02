using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class Character
    {
        int ID { get; set; }
        string Name { get; set; }
        string imageFile { get; set; }
        object Properties { get; set; }
        List<Action> Actions { get; set; }
    }
}
