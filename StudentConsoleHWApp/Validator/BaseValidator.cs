using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp;
using StudentConsoleHWApp.Commands;

namespace StudentConsoleHWApp.Validator
{
    public abstract class BaseValidator : IValidator
    {       
       private StringBuilder sb = new StringBuilder();
        string IValidator.ErrorMessage { get { return sb.ToString();} }
        public string[] param;       

        public BaseValidator(string[] param)
        {
            this.param = param;
        }               

        public bool IdValidation(string id)
        {
            foreach (char sumbol in id)
            {
                if (Char.IsLetter(sumbol))
                {
                    sb.AppendLine("Id не верный");
                    return false;
                }
            }
            return true;

        }

        public bool NameValidation(string name)
        {
            foreach (char sumbol in name)
            {
                if (Char.IsDigit(sumbol) && name.Length <= 50)
                {
                    sb.AppendLine("Имя не должно содержать цифры");
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
                    sb.AppendLine("Фамилия не должна сожержать цифры");
                    return false;
                }
            }
            return true;
        }

        public bool AgeValidation(string age)
        {
            foreach (char sumbol in age)
            {
                if (Char.IsLetter(sumbol) && int.Parse(age) > 18 && int.Parse(age) < 100)
                {
                    sb.AppendLine("Возраст не должен содержать буквы и выходить из диапазона от 18 до 99 лет ");
                    return false;
                }
            }
            return false;
        }

        public bool GenderValidation(string gender)
        {
            switch (gender.ToUpper())
            {
                case "M":
                    return true;                  
                case "Ж":
                    return true;                    
                case "МУЖ":
                    return true;                    
                case "ЖЕН":
                    return true;                    
                case "МУЖЧИНА":
                    return true;                    
                case "ЖЕНЩИНА":
                    return true;                   
                default:
                    sb.AppendLine("Это абракадабра, введите свой пол.");
                    return false;                
            }
        }

        public abstract bool Validate();        
    }
}
