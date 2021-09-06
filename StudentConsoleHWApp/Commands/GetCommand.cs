using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Commands
{
    class GetCommand : Command
    {
        public GetCommand(Repository repository, string[] parametrs)
             : base(repository, parametrs)
        {
            validator = new DeleteValidator(parametrs);
        }

        public override string Execute()
        {
            
            bool result = false;

            repository.Get(int.Parse(parametrs[1]));

            return result ? $"Студент {int.Parse(parametrs[1])} найден" : $"Студента {int.Parse(parametrs[1])} не существует ";
            
        }
    }
}
