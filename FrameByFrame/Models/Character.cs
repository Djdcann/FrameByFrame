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
        public Smash SmashU { get; set; }
        public Smash SmashF { get; set; }
        public Smash SmashD { get; set; }
        public Aerial AerialU { get; set; }
        public Aerial AerialF { get; set; }
        public Aerial AerialD { get; set; }
        public Aerial AerialB { get; set; }
        public Aerial AerialN { get; set; }

        public IEnumerable<Special> Specials { get; set; }

        public IEnumerable<Normal> Normals
        {
            get { return new List<Normal>() { this.TiltU, this.TiltF, this.TiltD }; }
        }
        public IEnumerable<Smash> Smashes
        {
            get { return new List<Smash>() { this.SmashU, this.SmashF, this.SmashD }; }
        }
        public IEnumerable<Aerial> Aerials
        {
            get { return new List<Aerial>() { this.AerialU, this.AerialF, this.AerialD, this.AerialB, this.AerialN }; }
        }

        public IEnumerable<Action> getAttacks()
        {
            List<Action> a = new List<Action>();
            a.AddRange(Normals);
            a.AddRange(Smashes);
            a.AddRange(Aerials);
            a.AddRange(Specials);
            a.Add(Grab);
            a.Add(GrabD);
            return a;
        }

        public List<Action> Actions { get; set; }

        public Character(int ID, string Name, string ImageFile)
        {
            this.ID = ID;
            this.Name = Name;
            this.ImageFile = ImageFile;
            this.Attributes = new CharacterProperties();
            this.Actions = new List<Action>();
        }

        public Character(){}

        public Character(string name)
        {
            Character c = this.fromJson(System.IO.File.ReadAllText(@"C:\Users\Derek\Desktop\SP\" + name+".json"));

            this.ID = c.ID;
            this.Name = c.Name;
            this.ImageFile = c.ImageFile;
            this.Attributes = c.Attributes;
            this.Actions = c.Actions;
        }

        private Character fromJson(string json)
        {
            Character c = JsonConvert.DeserializeObject<Character>(json);
            return c;
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
