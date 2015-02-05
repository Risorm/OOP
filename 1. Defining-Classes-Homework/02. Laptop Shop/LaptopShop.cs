using System;

namespace _02.Laptop_Shop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            var lenovo = new Laptop("Lenovo Yoga 2 Pro", 2259.3243m, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "Li-Ion", 4, 2550, 4.5);
            var someLaptop = new Laptop("Pravets", 1500.33m);
            Console.WriteLine(lenovo);
            Console.WriteLine(someLaptop);
        }
    }
}