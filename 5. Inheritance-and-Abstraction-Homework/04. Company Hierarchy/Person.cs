using System;


namespace _04.Company_Hierarchy
{
    public abstract class Person : IPerson
    {
       public Person(int id, string firstName, string lastName)
       {
           this.Id = id;
           this.FirstName = firstName;
           this.LastName = lastName;
       }
       
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("id: {0}, First Name: {1}, Last Name: {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}
