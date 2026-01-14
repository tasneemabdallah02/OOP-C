using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace project14_1
{
    internal class Program
    {
        abstract class Person
        {
           private int Id;
           private string Name;
           public int id
            {
                get { return Id; }
                set { if (value > 0)
                    {
                        Id = value;
                    }
                    else
                        Console.WriteLine("Invalid");
                        }
            }

           public string name
            {
                get { return Name; }
                set { Name = value; }
            }
            public Person(int Id, string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }
            public abstract void GetRole();
            public virtual void GetInfo()
            {
                Console.WriteLine("ID: " + Id);
                Console.WriteLine("Name: "+ Name);

            }
        }
        class Student:Person
        {
            private string Major;
            private double GPA;
            public string major
            {
                get { return Major; }
                set { Major = value;  }
            }
            public double gpa
            {
                get { return GPA; }
                set { GPA = value; }
            }
            public Student(int Id , string Name,string Major, double GPA) :base(Id,Name)
            {
                this.Major = Major;
                this.GPA = GPA;

            }
            public override void GetRole()
            {
                Console.WriteLine("Student");
            }
            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine("Major: " + Major);
                Console.WriteLine("GPA: " + GPA);
            }
        }
        class Instructor : Person
        {
            private string Department;
            private double Salary;

            public string department
            {
                get { return Department;}
                set { Department = value; }
            }
            public double salary
            {
                get { return Salary;}
                set
                {
                    if (value > 0)
                        Salary = value;
                    else
                        Console.WriteLine("Invalid!!");
                }
            }
            public Instructor(int Id, string Name,string Department,double Salary) : base(Id, Name)
            {
                this.Department = Department;
                this.Salary = Salary;
            }
            public override void GetRole()
            {
                Console.WriteLine("Instructor");
            }
            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine("Department: " + Department);
                Console.WriteLine("Salary: " + Salary+" JOD");
            }
        }

        static void Main(string[] args)
        {
            Person p1 = new Student(1, "Mohd", "Computer Engineering", 3.5);
            Person p2 = new Instructor(2, "Dr.Alina", "Computer Engineering", 1500);
            Console.WriteLine("===== Person 1 =====");
            p1.GetRole();
            p1.GetInfo();
            Console.WriteLine("===== Person 2 =====");
            p2.GetRole();
            p2.GetInfo();

        }

    }
}
