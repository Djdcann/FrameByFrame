using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        protected string lagClass = "lag";
        protected string activeClass = "hit";
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

        public virtual string ganttChart()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb.Append("<table class='gantt'><tr>");
            sb2.Append("</tr><tr>");
            int s = 1;
            for(int i=0;i<=StateChange.Length;i++)
            {
                int a = i < StateChange.Length ? StateChange[i] : FAF;
                int l = a - s;
                string c = i % 2 == 0 ? lagClass : activeClass;
                sb.Append($"<td class='{c}' width='{(float)l*100/FAF}%'>{l}</td>");
                sb2.Append($"<td>{s}</td>");
                s = a;
            }
            sb2.Append($"<td>{FAF}</td>");
            sb.Append(sb2);
            sb.Append("</tr></table>");
            return sb.ToString();
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
