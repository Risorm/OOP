using System;
using System.Collections.Generic;

namespace _03.PC_Catalog
{
    public static class PcCatalog
    {
        private static void Main(string[] args)
        {
            Component processor = new Component("Pentium II", 54m, "Cache 4MB, 333 MHz");
            Component gaphicsCard = new Component("Nvidia", 384m, "333 MHz, 8GB");
            Component motherboard = new Component("Intel", 345m);
            Component screen = new Component("14-inch IPS", 320m);
            Component psu = new Component("GE", 23m, "20 W, 220 V");
            List<Component> componentsLenovo = new List<Component>()
            {
                processor,
                motherboard,
                gaphicsCard
            };
            List<Component> componentsCustomPC = new List<Component>()
            {
                processor,
                motherboard,
                screen
            };
            List<Component> componentsCustomPC2 = new List<Component>()
            {
                processor,
                motherboard,
                psu,
                gaphicsCard
            };
            Computer laptop = new Computer("Lenovo", componentsLenovo);
            Computer pc = new Computer("CustomPC", componentsCustomPC);
            Computer pc2 = new Computer("CustomPC2", componentsCustomPC2);
            List<Computer> computers = new List<Computer>()
            {
                laptop,
                pc,
                pc2
            };
            computers.Sort(delegate(Computer x, Computer y)
            {
                return x.Price.CompareTo(y.Price);
            });
            
            foreach (Computer computer in computers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}