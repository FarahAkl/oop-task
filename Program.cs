using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace oop_task
{
    class car
    {
        public int speed;
        public string brand;
        public int model;
        public string color;
        public string number;
        public int price;
        public car()
        {
            speed = 200;
            brand = "bmw";
            model = 2006;
            color = "white";
            number = "abc 1234";
            price = 200000;
        }
        public void print()
        {
            Console.WriteLine("the speed of the car is " + speed + "km/s");
            Console.WriteLine("the car brand is " + brand);
            Console.WriteLine("the model of the car is " + model);
            Console.WriteLine("the color of the car is " + color);
            Console.WriteLine("the car number is" + number);
            Console.WriteLine("the price = " + price + " $");

        }
        public void Set_data()
        {
            Console.WriteLine("please enter the speed of the car");
            speed = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the brand of the car");
            brand = Console.ReadLine();
            Console.WriteLine("please enter the model of the car");
            model = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the color of the car");
            color = Console.ReadLine();
            Console.WriteLine("please enter the number of the car");
            number = Console.ReadLine();
            Console.WriteLine("please enter the price of the car");
            price = int.Parse(Console.ReadLine());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car a = new car();
            Console.WriteLine("the data of the car a :");
            a.print();
            Console.WriteLine("----------------------------------");
            car b = new car();
            Console.WriteLine("the data of the car b :");
            b.Set_data();
            Console.WriteLine("-----------------------------------");
            b.print();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("the data of the car c :");
            car c = new car();
            c.Set_data();
            Console.WriteLine("-----------------------------------");
            c.print();

        }
    }
}
