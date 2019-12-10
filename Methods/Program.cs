using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using a Console application (this means the methods will be static), create a method  named ReverseWord that accepts 1 parameter of type string and has a return type
            //of string.  The method should reverse the string (using a loop) and return the reversed string.  e.g. if someone passed in the value "hello" it would return "olleh"
            //Create another method named Numbers that accepts 2 parameters, both of type int and has a return type of void.The method should output all of the numbers between
            //1 and 100 that are divisible by both the first parameter and the second parameter to the console window.
            //The main method should call your two methods appropriately.For the ReverseWord, check to see if the word you passed in is equal to the same one that was returned.
            //This is called a palindrome(Links to an external site.).If it is a palindrome, tell the user it is, otherwise tell them the word in reverse.

            string userWord, reverseWord;
            int val, val2;

            Console.WriteLine("Please enter a word");
            userWord = Console.ReadLine().ToLower();

            reverseWord = ReverseWord(userWord);

            if(reverseWord == userWord)
            {
                Console.WriteLine("The word you entered is a palindrome...why are you asking to have a palidrome reversed? Are you kidding me? I spend all this" +
                    " time writing a somewhat sophisticated program just so you can ask for what a palindrome looks like backwards? IT'S THE SAME FRIGGIN WORD! Ugh anyway");
            }
            else
            {
                Console.WriteLine(reverseWord);
            }

            Console.WriteLine("Can I has the first number?");
            val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What about the second number?");
            val2 = Convert.ToInt32(Console.ReadLine());

            Numbers(val, val2);

            Console.ReadKey();

        }
        static string ReverseWord(string s)
        {
            char[] charArray = s.ToCharArray();
            string newWord = "";
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                newWord += charArray[i];
            }
            return newWord;
        }

        static void Numbers(int val, int val2)
        {
            for (int i = 1; i < 101; i++)
            {
                if(val % i == 0)
                {
                    if(val2 % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
