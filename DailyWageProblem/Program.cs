using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Daily Wage Computational Problem !");
            DailyWage attendance = new DailyWage();
            attendance.isPresent();
            Console.ReadLine();
        }
    }
}
