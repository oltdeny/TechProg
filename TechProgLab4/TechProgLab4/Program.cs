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
            Student s1 = new Student("Alex", 21, 3);
            Human.sayHelloTo(s1);
            AbstractHumon.makeStep(1);
            Console.ReadKey();
        }
    }

    public static class AbstractHumon {
        public static void makeStep(int steplength) {
            Console.WriteLine("Some abstract human make step with length: " + steplength);
        }
    }

    abstract class Human
    {
        protected string name;
        protected int age;

        static string description = "This is class of Human:)";
        static int average_age = 28;

        public static void sayHelloTo(Human person)
        {
            Console.WriteLine("Hello, " + person.name);
        }

        static Human()
        {
            Console.WriteLine("You have created the first Human object");   
        }

        public Human(string name, int age)
        {
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

        public override void getInfo()
        {
            Console.WriteLine("Info: " + this.GetType().Name + ", " + this.name + ", " + this.age + ", cours: " + this.getCourse());
        }

        public Student(string name, int age, int course)
           : base(name, age)
        {
            this.course = course;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Student))
                return false;
            else
                return course == ((Student)obj).course & name == ((Student)obj).name & age == ((Student)obj).age;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return "Student: " + name + ", course: " + course.ToString() + ", age: " + age.ToString();
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

        public override void getInfo()
        {
            Console.WriteLine("Info: " + this.GetType().Name + ", " + this.name + ", " + this.age + ", subject: " + this.getSubject());
        }

        public Teacher(string name, int age, string subject)
           : base(name, age)
        {
            this.subject = subject;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Teacher))
                return false;
            else
                return subject == ((Teacher)obj).subject & name == ((Teacher)obj).name & age == ((Teacher)obj).age;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return "Teacher: " + name + ", subject: " + subject + ", age: " + age.ToString();
        }
    }
}
