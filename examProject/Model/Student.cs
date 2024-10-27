using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Model
{
    internal class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
        public string SelectedCategory { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n +" +
                $"Surname: {Surname}\n +" +
                $"Login: {Login}\n +" +
                $"Category: {SelectedCategory}\n +" +
                $"Score: {Score}");
        }

    }
}
