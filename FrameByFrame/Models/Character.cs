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
        private static string jsonPath = "chardata/";

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
            a.AddRange(GetNormals());
            a.AddRange(GetSmashes());
            a.AddRange(GetAerials());
            a.Add(Grab);
            a.Add(Jabs.ElementAt(0));
            a.AddRange(Specials);

            return a;
        }

        public IEnumerable<Action> getActions()
        {
            List<Action> a = new List<Action>();
            a.AddRange(GetNormals());
            a.AddRange(GetSmashes());
            a.AddRange(GetAerials());
            a.Add(Grab);
            a.Add(GrabD);
            a.AddRange(Jabs);
            a.AddRange(Specials);

            return a;
        }

        public Character(Roster ID, string Name)
        {
            this.ID = (int)ID;
            this.Name = Name;
            this.ImageFile = ID.ToString() + ".png";
            this.Attributes = new CharacterProperties();
            this.Jabs = new List<Jab>();
            this.Specials = new List<Special>();
        }

        public static Character fromID(Roster ID)
        {
            string fn = ID.ToString();
            return getFromName(fn);
        }

        public Character() { }

        public static Character getFromName(string name)
        {
            string fn = name.ToLower().Replace(" ", "_");
            string json = System.IO.File.ReadAllText(jsonPath + fn + ".json");
            Character c = fromJson(json);
            c.ImageFile = fn + ".png";

            return c;
        }

        public List<Normal> GetNormals()
        {
            return new List<Normal>() {
                TiltU,
                TiltF,
                TiltD,
                DashA
            };
        }
        public List<Smash> GetSmashes()
        {
            return new List<Smash>() {
                SmashU,
                SmashF,
                SmashD
            };
        }
        public List<Aerial> GetAerials()
        {
            return new List<Aerial >() {
                AerialU,
                AerialF,
                AerialD,
                AerialB,
                AerialN
            };
        }
        public List<Evasive> GetEvasive()
        {
            return new List<Evasive>() {
                Airdodge,
                Spotdodge,
                RollF,
                RollB
            };
        }

        private static Character fromJson(string json)
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

        public List<Tuple<Action, int>> getFrameWindows(Action a, bool perfectShield=false)
        {
            List<Tuple<Action, int>> fw = new List<Tuple<Action, int>>();

            foreach(Action s in getAttacks())
            {
                int window = a.getEndlag() - s.getStartup(Attributes.Jumpsquat, perfectShield);
                fw.Add(Tuple.Create(s, window));
            }
            return fw;
        }
    }
}
