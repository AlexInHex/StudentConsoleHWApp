using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleHWApp.Validator
{
    internal class ListValidator : BaseValidator
    {
        public ListValidator(string[] parametrs) : base (parametrs)
        { }

        public override string ValidationExecute()
        {
            if (CommandValidation(param[0]))
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
