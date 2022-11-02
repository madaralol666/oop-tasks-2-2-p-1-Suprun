using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_tasks_2_2_p_1_Suprun.Core
{
    public class User
    {
        public User(string login, string name, string lastname, int age, DateTime registrationDate)
        {
            Login = login;
            Name = name;
            Lastname = lastname;
            Age = age;
            RegistrationDate = registrationDate;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public readonly DateTime RegistrationDate;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine
                ($"Login: {Login}\n" +
                $"Name: {Name}\n" +
                $"Surname: {Lastname}\n" +
                $"Age: {Age}\n" +
                $"Registration date: {RegistrationDate}");
        }
    }
}
