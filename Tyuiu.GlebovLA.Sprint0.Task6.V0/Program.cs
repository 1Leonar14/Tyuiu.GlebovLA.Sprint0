using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GlebovLA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.GlebovLA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] {1,2,3,4,5 };
            Console.WriteLine("Сумма " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Произведение " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
