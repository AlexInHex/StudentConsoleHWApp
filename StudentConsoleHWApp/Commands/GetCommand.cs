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

            Repository.repository.Get(id);

            return result ? $"Студент {id} найден" : $"Студента {id} не существует ";
            
        }
    }
}
