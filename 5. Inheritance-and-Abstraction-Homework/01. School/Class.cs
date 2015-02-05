using System;
using System.Collections.Generic;

namespace _01.School
{
    class Class
    {
        private static List<string> enteredIdentifiers;
        private string textIdentifier;

        static Class()
        {
            Class.enteredIdentifiers = new List<string>();
        }

        public Class(string textIdentifier, List<Teacher> teachers, string details = null)
        {
            Class.enteredIdentifiers.Add(textIdentifier);
            this.TextIdentifier = textIdentifier;
            this.Teachers = teachers;
            this.Details = details;
        }

        public Class(string textIdentifier, Teacher teacher, string details = null)
            : this(textIdentifier, new List<Teacher> { teacher }, details) { }


        public List<Teacher> Teachers { get; set; }
        public string Details { get; set; }


        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Invalid text identifier!");
                }
                if (enteredIdentifiers.Contains(value))
                {
                    throw new ArgumentException("This text identifier is already in use.");
                }
                this.textIdentifier = value;
            }
        }
    }
}