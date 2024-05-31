using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.Write("enter a number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("please only enter numbers");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("please only enter numbers < 2 billion! ");
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("something went wrong");
                }

                Console.WriteLine();
                Console.WriteLine("good bye");

                Console.ReadLine();
            }
                        

           

        }
    }
}
