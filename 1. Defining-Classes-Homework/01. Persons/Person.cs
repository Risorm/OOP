using System;

namespace _01.Persons
{
    class Person
    {
        private string name;
        private string email;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name cannot be longer than 50 symbols.");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 100 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100.");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Email is not valid.");
                }
                this.email = value;
            }
        }

        public Person (string name, int age, string email)
        {
            this.Name = name;
            this.Email = email;
            this.Age = age;
        }
        public Person (string name, int age) : this(name, age, null) {}

        public override string ToString() 
        {
            if (!String.IsNullOrEmpty(this.Email))
            {
                return String.Format("Name: {0}, Email: {1}, Age: {2}", this.Name, this.Email, this.Age);
            }
            else
            {
                return String.Format("Name: {0}, Age: {1}", this.Name, this.Age);
            }
        }
    }
    class Persons
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", 17, "ivan@dgd.bg");
            Console.WriteLine(ivan);
            Person pesho = new Person("Pesho", 95);
            Console.WriteLine(pesho);
        }
    }
}