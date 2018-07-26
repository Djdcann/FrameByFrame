using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class Window
    {
        public int Normal { get; set; }
        public int Perfect { get; set; }

        public Window(int N, int P)
        {
            this.Normal = N;
            this.Perfect = P;
        }


        public override string ToString()
        {
            return String.Format("{0}\t({1})", Normal.ToString("+#;-#;0"), Perfect.ToString("+#;-#;0"));
        }
    }
}
