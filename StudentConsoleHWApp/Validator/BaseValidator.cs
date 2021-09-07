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
            if (id != null)
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
            else
            {
                sb.AppendLine("ID не введен");
                return false;
            }
            

        }

        public bool NameValidation(string name)
        {
            if (name != null)
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
            else
            {
                sb.AppendLine("Не введено имя");
                return false;
            }

           
        }

        public bool SurnameValidation(string surname)
        {
            if (surname != null)
            {
                foreach (char sumbol in surname)
                {
                    if (Char.IsDigit(sumbol) && surname.Length <= 50)
                    {
                        sb.AppendLine("Фамилия не должна сожержать цифры");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                sb.AppendLine("Фамилия не введена.");
                return false;
            }
            
        }

        public bool AgeValidation(string age)
        {
            if (age != null)
            {
                foreach (char sumbol in age)
                {
                    if (Char.IsDigit(sumbol) && int.Parse(age) > 18 && int.Parse(age) < 100)
                    {                        
                        return true;
                    }
                }
                sb.AppendLine("Возраст не должен содержать буквы и выходить из диапазона от 18 до 99 лет ");
                return false;
            }
            else
            {
                sb.AppendLine("Возраст не введен.");
                return false;
            }           
        }

        public bool GenderValidation(string gender)
        {
            if (gender != null)
            {
                switch (gender.ToUpper())
                {
                    case "М":
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
                    case "M":
                        return true;
                    case "W":
                        return true;
                    case "MAN":
                        return true;
                    case "WOMAN":
                        return true;
                    case "BOY":
                        return true;
                    case "GIRL":
                        return true;
                    default:
                        sb.AppendLine("Это абракадабра, введите свой пол.");
                        return false;
                }                         
            }
            else
            {
                sb.AppendLine("Пол не введен.");
                return false;
            }
        }

        public abstract bool Validate();        
    }
}
