using System;
using System.Collections.Generic;

namespace Multimedia_Shop.Models
{
    public class Item
    {
        private string id;
        private string title;
        private decimal price;
        private List<string> genres;

        public string Id
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException("Id must cannot be empty or shorter than 4 symbols!");
                }
                this.id = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be empty!");
                }
                this.title = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public List<string> Genres { get; set; }

        public Item(string id, string title, decimal price)
        {
            this.Id = id;
            this.Title = title;
            this.price = price;
        }

        public Item(string id, string title, decimal price, List<string> genres) : this(id, title, price)
        {
            this.Genres = genres;
        }
    }
}