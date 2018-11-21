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
            Student s2 = new Student("Andrew", 21, 3);
            Console.WriteLine(s1 + ", hash-code = " + s1.GetHashCode());
            Console.WriteLine(s2 + ", hash-code = " + s2.GetHashCode());
            Console.WriteLine("Equals = " + s1.Equals(s2));
            Teacher t1 = new Teacher("Mishel", 34, "Maths");
            Teacher t2 = new Teacher("Mishel", 34, "Maths");
            Console.WriteLine(t1 + ", hash-code = " + t1.GetHashCode());
            Console.WriteLine(t2 + ", hash-code = " + t2.GetHashCode());
            Console.WriteLine("Equals = " + t1.Equals(t2));
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
