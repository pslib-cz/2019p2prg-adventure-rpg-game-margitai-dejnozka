using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Game.Models
{
    public class Player
    {
        public string Name { get; }
        public int Hp { get; set; }
        public Place currentPlace { get; set; }
        public int maxhp { get; set; }

        public Player(string name, int hp, Place _currentPlace)
        {
            Name = name;
            Hp = hp;
            currentPlace = _currentPlace;
            maxhp = hp;
        }
        public void SetHp(int newhp)
        {
            if(newhp > maxhp || newhp < 0)
            {
                //TODO - nelze provést
            }
            else
            {
                Hp = newhp;
            }
        }
        public void AddHp(int addhp)
        {
            if(Hp + addhp > maxhp)
            {
                //TODO - nelze provést
            }
            else
            {
                Hp += addhp;
            }
        }
        public void RmvHp(int rmvhp)
        {
            if (Hp - rmvhp > 0)
            {
                //TODO - nelze provést
            }
            else
            {
                Hp -= rmvhp;
            }
        }
        public void SetPlace(Place newPlace)
        {
            currentPlace = newPlace;
        }
        public void SetMaxHp(int newMaxhp)
        {
            maxhp = newMaxhp;
        }
    }
}
