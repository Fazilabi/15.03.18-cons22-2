using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Student();
            item.Name = "Fazil";
            item.Group = "P106";
            item.Teacher = new Teacher("samir", "P106");
            item.Mentor = new Mentor("Nermin", "p106");
            item.ShowDetails();

        }
    }
}
