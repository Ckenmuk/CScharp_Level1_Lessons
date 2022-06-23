using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson06
{

    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public User(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }
    }
    internal class Sample02
    {
        static void Main(string[] args)
        {
            ArrayList users = new ArrayList();

            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader.EndOfStream)
            {
                string[] words = streamReader.ReadLine().Split(' ');
                User user = new User(words[1], words[0], Convert.ToDateTime(words[2]));
                users.Add(user);
            }
            streamReader.Close();

            users.Add(1);
            users.Add(true);
            users.Add("Hello!");

            // upcasting - безопасен и автоматизирован
            // downcasting - не безопасен и может вызвать ошибки при компиляции


            foreach (object element in users)
            {
                if (element is User)
                {
                    Console.WriteLine($"{((User)element).Surname} {((User)element).Name} {((User)element).Birthday.ToShortDateString}");
                }
                
            }

            Console.WriteLine();
            // обобщенная коллекция:
            List<User> users02 = new List<User>();
            
            StreamReader streamReader02 = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader02.EndOfStream)
            {
                string[] words = streamReader02.ReadLine().Split(' ');
                User user = new User(words[1], words[0], Convert.ToDateTime(words[2]));
                users02.Add(user);

                
            }
            streamReader.Close();

            //users02.Add(1);
            //users02.Add(true);
            //users02.Add("Hello!");

            foreach (User element in users02)
            {
                Console.WriteLine($"{element.Surname} {element.Name} {element.Birthday.ToShortDateString}");
            }
        }
    }
}
