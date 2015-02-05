using System;

namespace _02.Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private decimal price;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                this.model = value;
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                this.manifacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                this.screen = value;
            }
        }
        public Battery Battery { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be less than 0");
                }
                this.price = value;
            }
        }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manifacturer = null, string processor = null, string ram = null, string graphicsCard = null, string hdd = null, string screen = null, string batteryType = null, int batteryNumCells = 0, int batteryCharge = 0, double batteryLife = 0)
            : this(model, price)
        {
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = new Battery(batteryType, batteryNumCells, batteryCharge, batteryLife);
        }

        public override string ToString()
        {
            var laptopSummary = "Model: " + this.Model;
            if (!string.IsNullOrEmpty(manifacturer))
            {
                laptopSummary += "; Manifacturer: " + this.Manifacturer;
            }
            if (!string.IsNullOrEmpty(processor))
            {
                laptopSummary += "; Processor: " + this.Processor;
            }
            if (!string.IsNullOrEmpty(ram))
            {
                laptopSummary += "; RAM: " + this.Ram;
            }
            if (!string.IsNullOrEmpty(graphicsCard))
            {
                laptopSummary += "; Graphics card: " + this.GraphicsCard;
            }
            if (!string.IsNullOrEmpty(hdd))
            {
                laptopSummary += "; Hdd: " + this.Hdd;
            }
            if (!string.IsNullOrEmpty(screen))
            {
                laptopSummary += "; Screen: " + this.Screen;
            }
            if (Battery != null)
            {
                laptopSummary += "; Battery: " + this.Battery;
            }
            if (price != 0)
            {
                laptopSummary += String.Format("; Price: {0:0.##} lv.", this.Price);
            }
            return laptopSummary;
        }
    }
}