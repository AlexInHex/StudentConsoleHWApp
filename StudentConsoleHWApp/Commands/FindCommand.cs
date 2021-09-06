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
            return $"Найдено {repository.Find(parametrs[1])} студентов. ";
        }
    }
}
