using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Commands
{
    class RandomCommand : Command
    {
        public RandomCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        { }

      /*  public override string Execute()
        {
            

            List<Student> existStudents = new List<Student>();

            for (int i = 0; i < Repository.students.Length; i++)
            {
                existStudents.Add(Repository.students[i]);
            }

            



           
            



        }*/
    }
}
