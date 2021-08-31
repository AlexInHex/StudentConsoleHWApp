using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class DeleteCommand : Command
    {
        public DeleteCommand(Repository repository, string[] parametrs)
             : base(repository, parametrs)
        { }

        public override string Execute()
        {
            int id = int.Parse(Console.ReadLine());
            bool result = false;
            for (int i = 0; i < Repository.students.Length; i++)
            {
                if (id == Repository.students[i].Id)
                {
                    Repository.students[i] = null;
                    result = true;
                    
                }
            }

            if (result)
            {
                return "Студент удален";
            }
            else
            {
                return $"Студент {Repository.students[id]} не найден";
            }
        }
    }
}
