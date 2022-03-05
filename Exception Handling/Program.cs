using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practicing
{
    class Program
    {
        static void Main()
        {
            double first = 0;
            double second = 0;
            while (true)
            {
                try
                {
                    Console.Write("First number: ");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second number: ");
                    second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The divison result is {first / second}!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\nTry again! (Press enter to continue...)");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}