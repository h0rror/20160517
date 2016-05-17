using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }
        public static int addYtoX(ref int X, ref int Y)
        {
            X +=
        }
        public static string[] readUntilEnd()
        {
            string{}inputs = new string[100];
            int inputcounter = 0;
          

            do
            {
                inputs[inputCounter] = Console.ReadLine();
                if (inputs[inputcounter]) == "end")
                    {
                    inputcounter = -1;

                }


            } while (true);

            return inputs;


        }
    }
}
