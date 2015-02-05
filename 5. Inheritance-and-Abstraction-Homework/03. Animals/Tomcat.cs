using System;


namespace _03.Animals
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male) { }
    }
}
