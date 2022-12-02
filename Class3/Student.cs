using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;

        public Student(string name, string surname, string group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }


        public void AllData()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }
}
