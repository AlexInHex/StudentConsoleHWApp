using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class GetCommand : Command
    {
        public GetCommand(Repository repository, string[] parametrs)
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
                    result = true;                                        
                }
            }

            return result ? $"Студент {Repository.students[id]} найден" : $"Студента {Repository.students[id]} не существует ";
            
        }
    }
}
