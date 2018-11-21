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
            s1.talk("Hello, I am "+s1.ToString());
            Teacher t1 = new Teacher("Sarah", 38, "History");
            t1.talk("Hello, I am " + t1.ToString());
            t1.move();
            s1.eat("sandwich");
            Console.ReadKey();
        }
    }

    interface IMovable
    {
        void move();
    }

    interface ITalkble
    {
        void talk(string phrase);
    }

    interface IEatable
    {
        void eat(string food);
    }

    abstract class Human : IMovable, ITalkble, IEatable
    {
        protected string name;
        protected int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void move()
        {
            Console.WriteLine("I am moving!");
        }

        public void talk(string phraze)
        {
            Console.WriteLine(phraze);
        }

        public void eat(string food)
        {
            Console.WriteLine("mmm, delicious " + food);
        }
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
