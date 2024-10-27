using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Model
{
    internal class Category
    {

        public string Name { get; set; }
        public List<Questions> Questions { get; set; } = new List<Questions>();

    }
}
