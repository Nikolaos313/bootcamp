using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9set3
{
    class Program
    {
        static void UserInput()
        {
           Console.WriteLine("Give a year"); 
            int year = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Give a month");
            int month = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Give a number day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a hour");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a second");
            int second= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Now is {day}/{month}/{year} and the time is {hour}:{minutes}:{second}");
        }
        static void Main(string[] args)
        {
            UserInput();
            
        }
    }
}
