using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Commands
{
    class Command
    {
        public string[] parametrs;
        public Repository repository;
        
        public Command(Repository repository, string[] parametrs)

        {
            this.parametrs = parametrs;
            this.repository = repository;
            
        }

        public virtual string Execute()
        {
            return "Нечего делать!";
        }       
    }
}
