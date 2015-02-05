using System;

namespace _03.PC_Catalog
{
    internal class Component
    {
        private string name;
        private decimal price;
        private string details;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty.");
                }
                this.details = value;
            }
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details = null) : this(name, price)
        {
            this.Details = details;
        }

        public override string ToString()
        {
            if (this.Details != null)
            {
                return String.Format("Name: {0}, Details: {1}, Price: {2} BGN.\n\r", this.Name, this.Details, this.Price);
            }
            else
            {
                return String.Format("Name: {0}, Price: {1} BGN.\n\r", this.Name, this.Price);
            }
        }
    }
}