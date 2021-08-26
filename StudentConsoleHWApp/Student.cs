using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp
{
    class Student
    {
        private string name;
        private string surname;
        private string gender;
        private int age;
        private int id;

        public Student(string n, string surN, string g, int a, int id)
        {
            n = name;
            surN = surname;
            g = gender;
            a = age;
            this.id = id;
        }
    }
}
