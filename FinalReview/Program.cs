using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReview
{
    class Program
    {
        static void Main(string[] args)
        { 
            int power;
            string answer, result;
            bool runLoop = true;

            List<string> ResultList = new List<string>();

            Equation userEquation = new Equation();

            while (runLoop)
            {
                Console.WriteLine("Please insert a value for the left opperand?");
                userEquation.Left = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please insert a value for the right opperand?");
                userEquation.Right = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What calculation would you like to perform? (+,-,*,^)");
                answer = Console.ReadLine();

                if (answer == "^")
                {
                    Console.WriteLine("What opperand would you like to raise to a power? (L,R)");
                    answer = Console.ReadLine().ToLower();

                    Console.WriteLine("What power would you like to raise the value to?");
                    power = Convert.ToInt32(Console.ReadLine());

                    if (answer == "r")
                    {
                        result = Convert.ToString(userEquation.RightToThePower(power));
                        Console.WriteLine(result);
                        ResultList.Add(result);
                    }
                    else
                    {
                        result = Convert.ToString(userEquation.LeftToThePower(power));
                        Console.WriteLine(result);
                        ResultList.Add(result);
                    }
                }
                else if (answer == "+")
                {
                    result = Convert.ToString(userEquation.Add());
                    Console.WriteLine(result);
                    ResultList.Add(result);
                }
                else if (answer == "-")
                {
                    result = Convert.ToString(userEquation.Subtract());
                    Console.WriteLine(result);
                    ResultList.Add(result);
                }
                else
                {
                    result = Convert.ToString(userEquation.Multiply());
                    Console.WriteLine(result);
                    ResultList.Add(result);
                }

                Console.WriteLine("Would you like to run another equation? (Y,N)");
                answer = Console.ReadLine().ToUpper();
                
                if(answer == "N")
                {
                    runLoop = false;
                }

            }

            Console.WriteLine("---------------Final Answers---------------");

            foreach (var finalAnswer in ResultList)
            {
                Console.WriteLine(finalAnswer);
            }

            Console.ReadKey();
        }
    }
}
