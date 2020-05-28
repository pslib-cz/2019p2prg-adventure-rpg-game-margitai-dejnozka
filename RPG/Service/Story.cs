using RPG.Models;
using RPG.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Service
{
    public class Story
    {
        public Dictionary<String, Place> Places = new Dictionary<String, Place>();
        public Story()
        {
            Places.Add("dul venku", new Place("Před doly", "Probudil si se"));
            Places["dul venku"].AddTravelPsb("dul vevnitr");
            Places["dul venku"].AddTravelPsb("tovarna venku");
            Places["dul venku"].AddTravelPsb("dul vevnitr");

            Places.Add("dul vevnitr", new Place("Uvnitř dolů", "Nacházíš se v dolech"));
            Places["dul vevnitr"].AddTravelPsb("dul venku");
            Places["dul vevnitr"].AddTravelPsb("dul zebrik");
            Places["dul vevnitr"].AddTravelPsb("dul vozik");
        }
    }
}
