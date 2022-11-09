
 
 
 
using System.IO;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
 
namespace Seria
{
        public class Person
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
 
        public Person() { }
 
        public Person(string imie, string nazwisko)
        {
            this.FirstName = imie;
            this.LastName = nazwisko;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
 
            //Person person = new Person();
            List<Person> person = new List<Person>();
            person.Add(new Person("Anna", "Karenina"));
            person.Add(new Person("Adam", "Małysz"));
            person.Add(new Person("Helga", "Niemra"));
 
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using (Stream s = File.Create("people.xml"))
            {
                serializer.Serialize(s, person);
                //serializer.Serialize(s, person3);
                s.Close();
            }
            Console.ReadKey();
 
        }
 
   }
 
}