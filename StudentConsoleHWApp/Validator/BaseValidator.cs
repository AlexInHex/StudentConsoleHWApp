using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp;
using StudentConsoleHWApp.Commands;

namespace StudentConsoleHWApp.Validator
{
    public abstract class BaseValidator : Command, IValidator
    {
       

        public string ErrorMessage { get;  set; }
        public string[] param;

        public BaseValidator(string[] param)
        {
            this.param = param;
        }

        public virtual string ValidationExecute()
        {
            return "Ничего не сделано. ";
        }

        public bool CommandValidation(string command)
        {
            foreach (char symbol in command)
            {
                if (Char.IsLetter(symbol))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IdValidation(string id)
        {
            foreach (char sumbol in id)
            {
                if (Char.IsDigit(sumbol))
                {
                    return true;
                }
            }
            return false;
        }

        public bool NameValidation(string name)
        {
            foreach (char sumbol in name)
            {
                if (Char.IsDigit(sumbol) && name.Length <= 50)
                {
                    return false;
                }
            }
            return true;
        }

        public bool SurnameValidation(string surname)
        {
            foreach (char sumbol in surname)
            {
                if (Char.IsDigit(sumbol) && surname.Length <= 50 )
                {
                    return false;
                }
            }
            return true;
        }

        public bool AgeValidation(string age)
        {
            foreach (char sumbol in age)
            {
                if (Char.IsDigit(sumbol) && int.Parse(age) > 18 && int.Parse(age) < 100)
                {
                    return true;
                }
            }
            return false;
        }

        public bool GenderValidation(string gender)
        {
            switch (gender.ToLower())
            {
                case "M":
                    return true;                  
                case "Ж":
                    return true;                    
                case "МУЖ":
                    return true;                    
                case "ЖЕН":
                    return true;                    
                case "МУЖСКОЙ":
                    return true;                    
                case "ЖЕНСКИЙ":
                    return true;                   
                default:
                    return false;                
            }
        }

        public abstract bool Validate();        
    }
}
