using System;
using System.Collections.Generic;

namespace PP_46411z
{
    public class Planet : IItemsCount
    {
        public Planet(string planetName, string terra, string liveable)
        {
            this.Planetname = planetName;
            this.Terra = terra;
            this.Live = liveable;
            this.Moons = new List<Moon>();
        }
        public Planet(string planet, List<Moon> m)
        {
            this.Planetname = planet;
            this.Moons = m;
        }
        public string Planetname { get; set; }
        public string Terra { get; set; }
        public string Live { get; set; }
        public List<Planet> Planets { get; set; }
        public List<Moon> Moons { get; set; }
        public void AddMoon(Moon m)
        {
            Moons.Add(m);
        }
        public void PrintMoons()
        {
            foreach (Moon m in Moons) Console.WriteLine(m.Moonname);
        }
        public void totalItems()
        {
            Console.WriteLine($"\t\t\to\t Name: {Planetname} \n" +
                               $"\t\t\t\t Type: {Terra} \n" +
                               $"\t\t\t\t Support life: {Live} \n" +
                                "\t\t\t\t Moons:");
        }
    }
}
