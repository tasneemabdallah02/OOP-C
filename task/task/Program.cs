using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        class Car
        {
           
            private string name;
            private string color;
            private int year;

            public void insertData(string name,string color,int year)
            {
                this.name =name;
                this.color = color;
               this.year = year;
            }
            private void Move()
            {
                Console.WriteLine("The Car Moved");
            }
           
            private bool IsClean()
            {
                return true;
            }
            public void printInfo()
            {
                Console.WriteLine("Car Name : "+name);
                Console.WriteLine( "Car's color : "+color);
                Console.WriteLine("Car's Year : "+year);
            }
        }
        


        static void Main(string[] args)
        {
            // Console.WriteLine("First Obj ");
            // Car car = new Car();
            // car.name = "Audi";
            // car.color = "black";
            // car.Year = 2026;
            // car.printInfo();
            // car.Move();
            // Console.WriteLine("\nFirst Obj ");
            //Car car1 = new Car();
            // car1.name = "Range Rover";
            // car1.color = "Red";
            // car1.Year = 2025;
            // car1.printInfo();
            Car car = new Car();
            car.insertData("Audi", "Red", 2026);
            car.printInfo();





        }
    }
}
