using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProgLab5Klimanov
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Men men = new Men("Daniel", -1);
            }
            catch (CustomException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
            Console.ReadLine();
        }
    }
    
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) {}
    }

    class Men
    {
        string name;
        int age;

        public static void validate(string name, int age)
        {

            if (Char.IsLower(name[0]))
            {
                throw new CustomException("Имя должно начинаться с заглавной буквы!!!");
            }
            if (age < 1 || age > 120)
            {
                throw new CustomException("Возраст должен быть в диапазоне от 1 до 120!!!");
            }
        }

        public Men(string name, int age)
        {
            validate(name, age);
            this.name = name;
            this.age = age;
        }
    }
}


