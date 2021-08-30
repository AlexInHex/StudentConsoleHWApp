using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class ListCommand : Command
    {
        public ListCommand(Repository repository, string[] parametrs)
           : base(repository, parametrs)
        { }

        public override string Execute()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var student in repository.List())
            {
                stringBuilder.AppendLine(student.ToString());               
            }

            return stringBuilder.ToString();
        }
    }
}
