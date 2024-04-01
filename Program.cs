using System.Diagnostics;

namespace TIME_CONVERSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time Conversion Program");
            Console.WriteLine("Pick a number below, for your desired Conversion");
            Console.WriteLine("1. Seconds To Minutes");
            Console.WriteLine("2. Minutes To Hours");
            Console.WriteLine("3. Hours To Days");
            Console.WriteLine("4. Days To Months");

            Console.WriteLine("Enter the chosen number between 1-4");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    SecToMin();
                    break;
                case 2:
                    MinToHr();
                    break;
                case 3:
                    HrToDy();
                    break;
                case 4:
                    DyToMths();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }
        }
        static void SecToMin () 
        {
            Console.WriteLine("Enter the number of Second/s: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            double min = sec / 60.0;
            Console.WriteLine(sec + " second/s is equal to " + min + " minute/s");
        }
        static void MinToHr () 
        {
            Console.WriteLine("Enter the number of minute/s: ");
            int min = Convert.ToInt32(Console.ReadLine());
            double hr = min / 60.0;
            Console.WriteLine(min + " minute/s id equal to " + hr + " hour/s");
        }
        static void HrToDy () 
        {
            Console.WriteLine("Enter the number of Hour/s: ");
            int hr = Convert.ToInt32(Console.ReadLine());
            double dy = hr / 24.0;
            Console.WriteLine(hr + " hour/s is equal to " + dy + " day/s");
        }
        static void DyToMths() 
        {
            Console.WriteLine("Enter the number of day/s: ");
            int dy = Convert.ToInt32(Console.ReadLine());
            double mths = dy / 30.0; //common number of days in a month
            Console.WriteLine(dy + " day/s is equal to " + mths + " month/s");   
        }
    }
}
