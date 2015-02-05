using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PC_Catalog
{
    internal class Computer
    {
        private List<Component> components;

        public string Name { get; set; }

        public decimal Price
        {
            get { return CalculatePrice(this.Components); }
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Computer must have at least one component!");
                this.components = value;
            }
        }

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        private decimal CalculatePrice(List<Component>list)
        {
            decimal price = 0;
            foreach (var component in list)
            {
                price += component.Price;
            }
            return price;
        }

        public override string ToString()
        {
            var computerDetails = "Name: " + this.Name;
            computerDetails = this.Components.Aggregate(computerDetails, (current, component) => current + (" Component: " + component));
            computerDetails += " Price: " + this.Price;
            return computerDetails;
        }
    }
}