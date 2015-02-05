using System;
using System.Linq;

namespace _03.Animals
{
    static class Animals
    {
        static void Main()
        {
            Kitten molly = new Kitten("Molly", 13);
            Console.WriteLine(molly);
            molly.ProduceSound();
            Frog kiro = new Frog("Kiro", 1, Gender.Female);
            Console.WriteLine(kiro);
            kiro.ProduceSound();
            Dog sharo = new Dog("Sharo", 5, Gender.Male);
            Console.WriteLine(sharo);
            sharo.ProduceSound();
            Tomcat pesho = new Tomcat("Pesho", 3);
            Console.WriteLine(pesho);
            pesho.ProduceSound();
            Cat pena = new Cat("Pena", 2, Gender.Female);
            Console.WriteLine(pena);
            pena.ProduceSound();

            Kitten dolly = new Kitten("Dolly", 2);
            Frog biro = new Frog("Biro", 3, Gender.Male);
            Dog paro = new Dog("Paro", 10, Gender.Female);
            Tomcat mesho = new Tomcat("Mesho", 1);
            Cat mena = new Cat("Mena", 1, Gender.Male);
            
            Animal[] animals = new Animal[]
            {
                molly, kiro, sharo, pesho, pena,
                dolly, biro, paro, mesho, mena

            };

            var averageAge = from o in animals
                             group o by new { GroupName = o.GetType().Name } into gr
                             select new
                             {
                                 gr.Key.GroupName,
                                 AvarageAge = gr.Average(o => o.Age)
                             };
            foreach (var animal in averageAge)
            {
                Console.WriteLine(String.Format("Type: {0}, Average age: {1:0.##}", animal.GroupName, animal.AvarageAge));
            }
        }
    }
}