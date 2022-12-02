using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    internal class Group
    {
        public int No;
        public int Limit;
        private Student[] _students;

        public Group(int no, int limit, Student[] students)
        {
            No = no;
            Limit = limit;
            Students = students;
        }


        private Student[] Students
        {
            get
            {
                return _students;
            }
            set
            {
                if (value.Length <= Limit)
                {
                    _students = value;
                }
                else
                {
                    Console.WriteLine("Group'un limitini kecir");
                }
            }
        }


        public void AddStudent(Student student)
        {
            int num = 0;
            foreach (var item in _students)
            {
                num++;
            }
            if (num < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Group'da yer yoxdur");
            }
        }


        public void GetStudents()
        {
            foreach (var item in _students)
            {
                item.AllData();
            }
        }
    }
}
