using System;
using System.Collections.Generic;

namespace Multimedia_Shop.Models
{
    public class Book : Item
    {
        private string author;

        public string Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Author must cannot be empty or shorter than 3 symbols!");
                }
                this.author = value;
            }
        }

        public Book(string id, string title, decimal price, string author, List<string> genres)
            : base(id, title, price, genres)
        {
            this.Author = author;
        }
        public Book(string id, string title, decimal price, string author, string genre)
            : this(id, title, price, author,new List<string>() {genre})
        {
        }
    }
}
