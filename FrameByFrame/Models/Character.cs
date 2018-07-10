using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FrameByFrame.Models
{
    public class Character
    {
        private string imagePath = "/images/portraits/";

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

        public string getJson()
        {
            string output = JsonConvert.SerializeObject(this);

            return output;
        }

        public string getImagePath()
        {
            return imagePath + imageFile;
        }
    }
}
