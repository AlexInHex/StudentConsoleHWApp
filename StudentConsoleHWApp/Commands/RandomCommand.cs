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

        public override string Execute()
        {
            int maxValue = 0;
            bool result = false;

            for (int i = 0; i < Repository.students.Length; i++)
            {
                if (maxValue < Repository.students[i].Id)
                {
                    maxValue = Repository.students[i].Id;
                }
            }
            
            Random rand = new Random();
            int id = rand.Next(0, maxValue);
            

            for (int i = 0; i < Repository.students.Length; i++)
            {
                if (id == Repository.students[i].Id)
                {
                    result = true;
                }
            }

            return result ? $"Случайный студент {Repository.students[id]} найден" : $"Студента {Repository.students[id]} не существует ";
        }
    }
}
