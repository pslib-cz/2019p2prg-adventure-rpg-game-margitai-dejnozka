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
        public Dictionary<string, Place> Places = new Dictionary<string, Place>();
        public Story()
        {
            Places.Add("dul venku", new Place("Před doly", "Probudil si se před opuštěným dolem, nevíš kdo jsi a co tu děláš, ale hrozně tě " +
                "bolí hlava. Můžeš se vydat do dolů, nedaleké továrny, nebo cestičkou do hor", "none"));
            Places["dul venku"].AddTravelPsb("dul vevnitr");
            Places["dul venku"].AddTravelPsb("tovarna venku");
            Places["dul venku"].AddTravelPsb("hory cesticka");

            Places.Add("dul vevnitr", new Place("Uvnitř dolů", "Vlezl jsi do dolu, cesta se zde rozděluje, můžeš zamířit k důlnímu vozíku, nebo " +
                "sešplhat dolů po žebříku", "none"));
            Places["dul vevnitr"].AddTravelPsb("dul venku");
            Places["dul vevnitr"].AddTravelPsb("dul zebrik");
            Places["dul vevnitr"].AddTravelPsb("dul vozik");

            Places.Add("dul vozik", new Place("Vedle důlního vozíku", "Dále tu cesta končí, ale ve vozíku si našel důlní helmu", "none"));
            Places["dul vozik"].AddTravelPsb("dul vevnitr");

            Places.Add("dul zebrik", new Place("Žebřík dolů", "Cesta tu pokračuje ale není vidět ani na krok, pokud nemáš zdroj světla, " +
            "tak se musíš vrátit", "none"));
            Places["dul zebrik"].AddTravelPsb("dul tmava mistnost");
            Places["dul zebrik"].AddTravelPsb("dul vevnitr");

            Places.Add("dul tmava mistnost", new Place("Tmavá místnost", "Místnost tu končí ale je zde trezor, pokud máš pasující klíč " +
            "tak ho můžeš otevřít", "svitilna"));
            Places["dul zebrik"].AddTravelPsb("dul trezor");
            Places["dul zebrik"].AddTravelPsb("dul zebrik");

            Places.Add("dul trezor", new Place("Trezor", "V trezoru si našel zlatou nugetku", "klic"));
            Places["dul zebrik"].AddTravelPsb("dul tmava mistnost");

            Places.Add("tovarna venku", new Place("Vchod do továrny", "Stojíš před továrnou, můžeš jít dovnitř, nebo se porozhlídnout " +
            "na opuštěným parkovišti vedle továrny", "none"));
            Places["tovarna venku"].AddTravelPsb("tovarna vraky");
            Places["tovarna venku"].AddTravelPsb("tovarna vevnitr");

            Places.Add("tovarna vraky", new Place("Vrakoviště vedle továrny", "Jeden z vraků vypadá pojízdně a má klíček v zapalování, " +
            "bez paliva ale nepojede", "none"));
            Places["tovarna vraky"].AddTravelPsb("tovarna venku");
            Places["tovarna vraky"].AddTravelPsb("tovarna vraky konec");

            Places.Add("tovarna vraky konec", new Place("Vrakoviště vedle továrny", "Nasedáš do auta a odjíždíš, přijel si do města...", "kanystr"));
            Places["tovarna venku"].AddTravelPsb("tovarna vraky");
            Places["tovarna venku"].AddTravelPsb("tovarna vevnitr");


        }
    }
}
