﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg.Model
{
    public class Item
    {
        public int Name { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }

        public Item(int name, int value, int weight)
        {
            Name = name;
            Value = value;
            Weight = weight;
        }
    }
}
