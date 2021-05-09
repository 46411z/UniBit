using System;
using System.Collections.Generic;

namespace PP_46411z
{
    public class Galaxy : IItemsCount
    {
        public Galaxy() { }
        public Galaxy(string name, string type, string age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
            this.Stars = new List<Star>();
        }
        public Galaxy(string name, List<Star> s)
        {
            this.Name = name;
            this.Stars = s;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Age { get; set; }
        public List<Star> Stars { get; set; }
        public List<Galaxy> Galaxies { get; set; }

        public void AddStar(Star st)
        {
            Stars.Add(st);
        }

        public void PrintGalaxies()
        {
            Console.WriteLine(Name);
        }
        public void totalItems()
        {
            Console.WriteLine($"Type: {Type} \n" +
                              $"Age: {Age} \n" +
                               "Stars:");
        }

        public void PrintStars()
        {
            foreach (Star s in Stars) Console.WriteLine(s.Starname);

        }
    }
}
