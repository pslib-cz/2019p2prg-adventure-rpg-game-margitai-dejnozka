using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Skill
    {
        public bool Learned;
        public string Name;
        public Skill(string name, bool learned)
        {
            Name = name;
            Learned = learned;
        }
        public void LearnSkill()
        {
            Learned = true;
        }

    }
}