using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameByFrame.Models
{
    public class Character
    {
        int ID { get; set; }
        public string Name { get; set; }
        public string imageFile { get; set; }
        public CharacterProperties Properties { get; set; }
        public List<Action> Actions { get; set; }

        public Character(int ID, string Name, string imageFile)
        {
            this.ID = ID;
            this.Name = Name;
            this.imageFile = imageFile;
        }


    }
}
