using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Student
    {
        public string Name;
        public Teacher Teacher;
        public Mentor Mentor;
        public string Group;
        public void ShowDetails()
        {
            
            Console.WriteLine("{0} adli telebe {1} qrupunun telebesidir, {2} muellimi ve {3} mentorunun nezareti altindadir", Name,Group,Teacher.Name,Mentor.Name);
        }
    }
}
