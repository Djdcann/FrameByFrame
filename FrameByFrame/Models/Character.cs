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
        private string jsonPath = "chardata/";

        public int ID { get; set; }
        public string Name { get; set; }
        protected string ImageFile { get; set; }
        public CharacterProperties Attributes { get; set; }

        public Evasive Airdodge { get; set; }
        public Evasive Spotdodge { get; set; }
        public Evasive RollF { get; set; }
        public Evasive RollB { get; set; }
        public Grab Grab { get; set; }
        public Grab GrabD { get; set; }
        public Normal TiltU { get; set; }
        public Normal TiltF { get; set; }
        public Normal TiltD { get; set; }
        public Normal DashA { get; set; }
        public Smash SmashU { get; set; }
        public Smash SmashF { get; set; }
        public Smash SmashD { get; set; }
        public Aerial AerialU { get; set; }
        public Aerial AerialF { get; set; }
        public Aerial AerialD { get; set; }
        public Aerial AerialB { get; set; }
        public Aerial AerialN { get; set; }

        public List<Special> Specials { get; set; }
        public List<Jab> Jabs { get; set; }

        public IEnumerable<Action> getAttacks()
        {
            List<Action> a = new List<Action>();
            a.Add(TiltU);
            a.Add(TiltF);
            a.Add(TiltD);
            a.Add(DashA);
            a.Add(SmashU);
            a.Add(SmashF);
            a.Add(SmashD);
            a.Add(AerialU);
            a.Add(AerialF);
            a.Add(AerialD);
            a.Add(AerialB);
            a.Add(AerialN);
            a.Add(Grab);
            a.Add(Jabs.ElementAt(0));
            a.AddRange(Specials);

            return a;
        }

        public Character(int ID, string Name, string ImageFile)
        {
            this.ID = ID;
            this.Name = Name;
            this.ImageFile = ImageFile;
            this.Attributes = new CharacterProperties();
            this.Jabs = new List<Jab>();
            this.Specials = new List<Special>();
        }

        public Character(){}

        public Character getFromName(string name)
        {
            string json = System.IO.File.ReadAllText(jsonPath + name + ".json");
            Character c = fromJson(json);
            c.ImageFile = name.ToLower() + ".png";

            return c;
        }

        private Character fromJson(string json)
        {
            return JsonConvert.DeserializeObject<Character>(json);
        }

        public string getJson()
        {
            string output = JsonConvert.SerializeObject(this);

            return output;
        }

        public string getImagePath()
        {
            return imagePath + ImageFile;
        }
    }
}
