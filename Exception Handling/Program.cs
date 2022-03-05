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
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message + "\nILLEGAL!!! (Press enter to continue...)");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                catch (FormatException ex1)
                {
                    Console.WriteLine(ex1.Message + "\nTry again. (Press enter to continue...)");
                    Console.ReadLine();
                    Console.Clear();
                }
                finally
                {
                    Console.WriteLine("dummy");
                }
            }
        }
    }
}