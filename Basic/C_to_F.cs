using System;

namespace TempratureCalculator
{
    class Celsius_to_Fahrenheit
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Skiv en tempratur der skal om skives til Celsius_to_Fahrenheit");
            Double input = Convert.ToDouble(Console.ReadLine());
            Double temps = Temp(input);
            Console.WriteLine($"{temps}");
        }

        private static double Temp(double a)
        {
            Double sum = (a * 1.8); 
            Double number = sum + 32; 
            return number;
        }

    }
}