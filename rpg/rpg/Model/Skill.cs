using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Skill
    {
        public bool Learned;
        public readonly string Name;
        public Skill(string name)
        {
            Name = name;
            Learned = false;
        }
        public void LearnSkill()
        {
            Learned = true;
        }

    }
}