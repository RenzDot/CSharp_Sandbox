using System;
using System.Reflection;


//Used to browse the methods and properties of a class without declaring the class
namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args) {
            //Below all uses System.Reflection library

            // Obtain Calculator class from Reflection.dll
            Assembly testAssembly = Assembly.LoadFile(@"c:\Test.dll");
            Type calculator = testAssembly.GetType("Test.Calculator");

            // Calculator instance
            object calculatorInstance = Activator.CreateInstance(calculator);

            //Use reflection to look into methods & properties
            PropertyInfo reflectedInfo = calculator.GetProperty("Number");
            double someValue = (double) reflectedInfo.GetValue(calculatorInstance, null);
            reflectedInfo.SetValue(calculatorInstance, 10d, null);
        }
    }

    public class Calculator
    {
        public Calculator() { }
    }
}