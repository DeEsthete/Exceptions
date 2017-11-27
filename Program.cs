using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //###

namespace Exceptions
{
    class Program
    {
        private static int counter = 0;
        static void Main(string[] args)
        {
            try
            {
                ToDo();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //try-catch-finally
            try
            {
                int[] numbers = new int[5];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = counter++;
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                //выполняется в любом случае
            }
            Console.ReadLine();
        }
        private static void ToDo()
        {
            bool badThing = true;
            //работа - =
            if (badThing)
            {
                throw new IndexOutOfRangeException();
            }
            
        }
    }
}
