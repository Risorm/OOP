using System;

namespace _02.Laptop_Shop
{
    class Battery
    {
        private string batteryType;
        private int batteryNumCells;
        private int batteryCharge;
        private double batteryLife;

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                if (value != null && value.Trim() == "")
                {
                    throw new ArgumentNullException("Value cannot be empty");
                }
                this.batteryType = value;
            }
        }

        public int BatteryNumCells
        {
            get
            {
                return this.batteryNumCells;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative");
                }
                this.batteryNumCells = value;
            }
        }

        public int BatteryCharge
        {
            get
            {
                return this.batteryCharge;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative");
                }
                this.batteryCharge = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative");
                }
                this.batteryLife = value;
            }
        }
        public Battery(string batteryType, int batteryNumCells, int batteryCharge, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryCharge = batteryCharge;
            this.BatteryNumCells = batteryNumCells;
            this.BatteryLife = batteryLife;
        }
        public override string ToString()
        {
            return string.Format("type: {0}, {1}-cells, {2} mAh, life: {3} hours", this.BatteryType, this.BatteryNumCells, this.BatteryCharge, this.BatteryLife);
        }
    }
}