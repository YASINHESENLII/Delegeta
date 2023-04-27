using System;

namespace _2ci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person person = new Person() { Name = "Yasin", SurName = "Hesenli", Age = 20 };
            Person person1 = new Person() { Name = "Hesen", SurName = "Hesenov", Age = 31 };
            people.Add(person);
            people.Add(person1);



            people.FindAll(people => people.Name == "Yasin").ForEach(people => Console.WriteLine(people));

            people.FindAll(person => person.SurName.EndsWith("ov") || person.SurName.EndsWith("ova")).ForEach(people => Console.WriteLine(people));

            people.FindAll(person => person.Age == 20).ForEach(people => Console.WriteLine(people));

           
        }
    }
}