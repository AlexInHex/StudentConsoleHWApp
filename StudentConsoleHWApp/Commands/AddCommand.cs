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
        { }

        public override string Execute()
        {                                                          
            string newStudentName = parametrs[1];
            string newStudentSurname = parametrs[2];
            string newStudentGender = parametrs[3];
            int newStudentAge = int.Parse(parametrs[4]);

            Student newStudent = new Student(newStudentName, newStudentSurname, newStudentGender, newStudentAge);

            repository.Add(newStudent);

            return "Студент создан";                                                                        
        }
    }
}
