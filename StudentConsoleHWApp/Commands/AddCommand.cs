using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class AddCommand : Command
    {

        public AddCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {                        
            
        }

        public static Student Add()
        {
            Console.WriteLine("Введите через зяпятую: Имя, Фамилию, пол, возраст.");
            string userText = Console.ReadLine();
            string[] parametrs = userText.Split(',');
            int id = 1;

            if (parametrs.Length == 3)
            {
                string newStudentName = parametrs[0];
                string newStudentSurname = parametrs[1];
                string newStudentGender = parametrs[2];
                int newStudentAge = int.Parse(parametrs[3]);

                Student newStudent = new Student(newStudentName, newStudentSurname, newStudentGender, newStudentAge, id);
                id++;
                Repository.students[id - 1] = newStudent;
                return newStudent;
            }
            else
            {
                Student newStudent = new Student(null, null, null, 0, 0);
                return newStudent;

            }
        }
    }
}
