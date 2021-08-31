using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        { }

        public override string Execute()
        {
            string userText = Console.ReadLine();
            Student[] findStudents = new Student[Repository.students.Length];
            int count = 0;

            for (int i = 0; i < Repository.students.Length; i++)
            {
                if (Repository.students[i].Name.Contains(userText, StringComparison.OrdinalIgnoreCase) == true ||
                    Repository.students[i].Surname.Contains(userText, StringComparison.OrdinalIgnoreCase) == true)
                {
                    findStudents[count++] = Repository.students[i];
                } 
            }
            Array.Resize(ref findStudents, count);
            return $"Найдено {count} студентов. ";
        }
    }
}
