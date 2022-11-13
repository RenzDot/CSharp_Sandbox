using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IVehicle {}
    public abstract class Vehicle {
        public abstract void start();
    }

    public class Car : Vehicle {
        public Car() {}
        public override void start() {
            Console.WriteLine("started");
        }
    }

}
