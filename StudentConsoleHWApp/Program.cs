using System;
using StudentConsoleHWApp.Commands;
using StudentsConsoleApp;

namespace StudentConsoleHWApp
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CommandsParser commandParser = new CommandsParser(Repository.repository);

            Console.WriteLine("Список команд: add - добавить студента, edit - изменить студента, delete - удалить студента, find - найти студента, get - получить студента по id, list - вывести всех студентов, random - получить случайного студента. ");

            
            
            while (true)
            {
                switch ()
                {
                    case "ADD":
                        {
                            
                            
                            break;
                        }
                    case "edit":
                        {
                            
                            break;
                        }
                
                }

            }
            
        }
    }
}
