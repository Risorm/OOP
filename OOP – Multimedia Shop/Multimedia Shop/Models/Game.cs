using System;
using System.Collections.Generic;

namespace Multimedia_Shop.Models
{
    public class Game : Item
    {
        public AgeRestriction Restriction { get; set; }

        public Game(string id, string title, decimal price, List<string> genres, AgeRestriction ageRestriction=AgeRestriction.Minor) 
            : base (id, title, price, genres)
        {
            this.Restriction = ageRestriction;
        }
                public Game(string id, string title, decimal price, string genre, AgeRestriction ageRestriction)
            : this(id, title, price, new List<string>() { genre }, ageRestriction)
        {
        }
    }
}