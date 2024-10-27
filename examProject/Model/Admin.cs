using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Model
{
    internal class Admin
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Login: {Login}");
        }

    }
}
