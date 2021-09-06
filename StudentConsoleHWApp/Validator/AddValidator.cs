using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Validator
{
    internal class AddValidator : BaseValidator
    {

        public AddValidator(string[] parametrs)
            : base(parametrs)
        { }


        public override string ValidationExecute()
        {

            if (CommandValidation(param[0]) && NameValidation(param[1]) && SurnameValidation(param[2]) &&
                GenderValidation(param[3]) && AgeValidation(param[4]))
            {
                return "1";
            }

            return "0";
        }


        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
