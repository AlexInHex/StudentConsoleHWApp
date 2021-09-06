using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp;
using StudentConsoleHWApp.Validator;

namespace StudentConsoleHWApp.Validator
{
    internal class DeleteValidator : BaseValidator
    {
        public DeleteValidator(string[] parameters) : base(parameters)
        { }

        public override string ValidationExecute()
        {
            if (CommandValidation(param[0]) && IdValidation(param[1]))
            {
                return "1";
            }

            return "0";
        }

        public override bool Validate()
        {
            return false;
        }
    }
}
