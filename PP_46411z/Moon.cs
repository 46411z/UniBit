using System;
using System.Collections.Generic;

namespace PP_46411z
{
    public class Moon : IItemsCount
    {
        public Moon(string name)
        {
            this.Moonname = name;
        }
        public string Moonname { get; set; }
        public List<Moon> Moons { get; set; }
        public void totalItems()
        {
            Console.WriteLine($"\t\t\t\t\u2022\t {Moonname}");
        }
    }

}
