using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson08
{

    public class Person 
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; } 
        public int Age{ get; set; }
    }

    internal class Sample02
    {

        public static Person LoadPersonFromXml(string fileName)
        {
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            FileStream fileStream = new FileStream(fileName, 
                FileMode.Open, 
                FileAccess.Read);
            Person person = (Person)xmlSerializer.Deserialize(fileStream);
            // выражение ниже выведет null, если будет невозможно преобразовать число в строку
            // Person person2 = xmlSerializer.Deserialize(fileStream) as Person;
            
            fileStream.Close();
            return person;
        }

        public static void SavePersonToXml(string fileName, Person person)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, person);
            fileStream.Close();
        }

        static void Main(string[] args)
        {

            Person person = LoadPersonFromXml(AppDomain.CurrentDomain.BaseDirectory + 
                "Person.xml");
            if (person != null)
            {
                Console.WriteLine($"{person.LastName} " +
                    $"{person.FirstName} " +
                    $"{person.SecondName} " +
                    $"{person.Age}");

            }

            person.LastName = "Иванов";

            SavePersonToXml(AppDomain.CurrentDomain.BaseDirectory + "Person.new.xml", person);

            person = LoadPersonFromXml(AppDomain.CurrentDomain.BaseDirectory +
    "Person.new.xml");
            if (person != null)
            {
                Console.WriteLine($"{person.LastName} " +
                    $"{person.FirstName} " +
                    $"{person.SecondName} " +
                    $"{person.Age}");

            }

        }
    }
}
