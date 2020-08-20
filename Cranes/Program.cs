using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cranes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите общее число жупавликов");
            int S = Convert.ToInt32( Console.ReadLine());
            int Sum = S / 2;
            int Sum1 = Sum / 2;
            Console.WriteLine($" Катя сделала {Sum}  журавликов,  Серёжа сделал {Sum1} журавликов, Петя сделал {Sum1} журавликов.");
            Console.ReadKey();
        }
    }
}
