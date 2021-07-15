using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{TempConverter.CelsiustoFahrenheit(111)}");
            Console.WriteLine($"{TempConverter.FahrenheitToCelsius(79)}");
        
        }
    }
}
