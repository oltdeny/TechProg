using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProgLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.init("Alex", 21);
            s1.setCourse(3);
            Teacher t1 = new Teacher();
            t1.init("Mishel", 34);
            t1.setSubject("Maths");
            s1.sayHelloTo(t1);
            s1.getInfo();
            t1.getInfo();
            Console.ReadKey();
        }
    }

    abstract class Human
    {
        protected string name;
        protected int age;

        public void sayHelloTo(Human person)
        {
            Console.WriteLine("Hello, " + person.name);
        }

        public Human(string name, int age) {
            this.name = name;
            this.age = age;
        }
        abstract public void getInfo();
    
    }

    class Student : Human
    {
        int course;

        public void doHomeTask(string subject)
        {
            Console.WriteLine("I did homework on the subject " + subject);
        }
        public int getCourse()
        {
            return this.course;
        }

        override
        public void getInfo()
        {
            Console.WriteLine("Info: " + this.GetType().Name + ", " + this.name + ", " + this.age + ", cours: " + this.getCourse());
        }

        public Student(string name, int age, int course)
           : base(name, age)
        {
            this.course = course;
        }
    }

    class Teacher : Human
    {
        string subject;

        public string getSubject()
        {
            return this.subject;
        }

        public void giveTask(string task)
        {
            Console.WriteLine("Your task on the " + this.subject + " is " + task);
        }
        override
        public void getInfo()
        {
            Console.WriteLine("Info: " + this.GetType().Name + ", " + this.name + ", " + this.age + ", subject: " + this.getSubject());
        }
        public Teacher(string name, int age, string subject)
           : base(name, age)
        {
            this.subject = subject;
        }
    }
}
