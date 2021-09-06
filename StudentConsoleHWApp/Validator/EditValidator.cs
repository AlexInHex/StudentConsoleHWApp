using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Validator
{
    internal class EditValidator : BaseValidator
    {
        public EditValidator(string[] parametrs)
            : base(parametrs)
        { }

        public override string ValidationExecute()
        {
            if (CommandValidation(param[0]) && IdValidation(param[1]) && NameValidation(param[2]) &&
                SurnameValidation(param[3]) && GenderValidation(param[4]) && AgeValidation(param[5]))
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
