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
            
            bool result = false;

            repository.Delete(int.Parse(parametrs[1]));

            if (result)
            {
                return "Студент удален";
            }
            else
            {
                return $"Студент {Repository.students[int.Parse(parametrs[1])]} не найден";
            }
        }
    }
}
