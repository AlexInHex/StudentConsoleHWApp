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

        public string Name { get; }
        public string Surname { get; }
        public string Gender { get; }
        public int Age { get; set; }
        public int Id { get; set; }            

        public Student(int id, string n, string surN, string g, int a)
        {
            name = n;
            surname = surN;
            gender = g;
            age = a;
            this.id = id;
        }

        public Student(string n, string surN, string g, int a): this (0, n, surN, g, a)
        {
            name = n;
            surname = surN;
            gender = g;
            age = a;

        }

        public void Update(Student student)
        {
            name = student.Name;
            surname = student.Surname;
            gender = student.Gender;
            age = student.Age;
        }
    }
}
