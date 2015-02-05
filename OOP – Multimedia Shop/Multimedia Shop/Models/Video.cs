using System;
using System.Collections.Generic;

namespace Multimedia_Shop.Models
{
    public class Video : Item
    {
        private double length;

        public double Length
        {
            get { return this.length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Length cannot be negative!");
                }
                this.length = value;
            }
        }
        public Video(string id, string title, decimal price, double length, List<string> genres)
            : base(id, title, price, genres)
        {
            this.Length = length;
        }
        public Video(string id, string title, decimal price, double length, string genre)
            : this(id, title, price, length, new List<string>() { genre })
        {
        }
    }
}
