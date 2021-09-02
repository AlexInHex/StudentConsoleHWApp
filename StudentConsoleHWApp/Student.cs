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

        public Student(int idStudent, string nameStudent, string surNameStudent, string genderStudent, int ageStudent)
        {
            name = nameStudent;
            surname = surNameStudent;
            gender = genderStudent;
            age = ageStudent;
            id = idStudent;
        }

        public Student(string nameStudent, string surNameStudent, string genderStudent, int ageStudent)
            : this (0, nameStudent, surNameStudent, genderStudent, ageStudent)
        {
            name = nameStudent;
            surname = surNameStudent;
            gender = genderStudent;
            age = ageStudent;

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
