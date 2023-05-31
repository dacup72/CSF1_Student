using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
    internal class OperatorsUnsolved
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mathematical Operators");

            Console.WriteLine();

            //concatenation review
            Console.WriteLine(3 + 5);//adding two literal numbers
            Console.WriteLine(3 + "5");//35 because 5 is a string

            //other basic operators

            Console.WriteLine(12 - 8);//subtraction

            Console.WriteLine(10 / 5);//division

            Console.WriteLine(2 * 11);//multiplication

            int legos = 15 + 27;//addition
			Console.WriteLine(legos);

            //We can make a lego car from 9 pieces. How many
            //cars can we make?
            //===========================   INSERT CODE BELOW   ========================================



            //What if we want to see the fraction answer?
            //For that we need modulus:
            //===========================   INSERT CODE BELOW   ========================================



            Console.WriteLine();
            //we have 75 nails. It takes 30 nails to make a dresser.
            //How many dressers can we make, and how many nails
            //would be left over?
            int nails = 75;
            //===========================   INSERT CODE BELOW   ========================================





            Console.WriteLine();
            //Let's do this together
            //There are 100 cookies and 47 students.
            //How many cookies does each student get and how many
            //cookies are left over?
            int cookies = 100, students = 47;
            //===========================   INSERT CODE BELOW   ========================================



            Console.WriteLine();
            //Unary operators are used to quickly
            //increment/decrement a variable's value.
            int hobbits = 2;
            Console.WriteLine("We have " + hobbits + " hobbits");

            //To add one the long way we would write it like:
            //===========================   INSERT CODE BELOW   ========================================


            //short cut (unary operator)
            //===========================   INSERT CODE BELOW   ========================================


            //To decrease the value by one the long way:
            //===========================   INSERT CODE BELOW   ========================================


            //unary operator
            //===========================   INSERT CODE BELOW   ========================================



            Console.WriteLine();
            //Above we put the unary operator after the variable name,
            //however it can also come before the variable, which effects
            //how the incrementation occurs.
            //variable++ is a POST-FIX (happens LAST)
            //++variable is a PRE-FIX (happens FIRST)

            int goblins = 12, orcs = 1;
            // POST-FIX
            //===========================   INSERT CODE BELOW   ========================================



            Console.WriteLine(); 
            int xboxGames = 12, psGames = 1;
            // PRE-FIX
            //===========================   INSERT CODE BELOW   ========================================




            Console.WriteLine();

            //Assignment operators:
            //= assigns the value on the right to the variable on the left.
            //It can also be used with mathematical operators to create a 
            //shortcut to do math on a variable and reassign the value back
            //to that variable.
            //examples of assignment operators:
            // +=, -=, *=, /=, %=

            int players = 2;
            Console.WriteLine(players);

            //Long way to add 4 to players:
            //===========================   INSERT CODE BELOW   ========================================



            //Assignment operator (shortcut)
            //===========================   INSERT CODE BELOW   ========================================



            //Multiply by 3 the long way:
            //===========================   INSERT CODE BELOW   ========================================



            //Assignment operator multiply by 3:
            //===========================   INSERT CODE BELOW   ========================================



            //Let's do this together
            //Using the players variable:
            //Divide by 3 both the long way and short way.
            //Print the answer each time
            //===========================   INSERT CODE BELOW   ========================================



            //Then subtract by 8 both the long and short way.
            //Print the answer each time.
            //===========================   INSERT CODE BELOW   ========================================



            //Finally, modulus by 2 using the shortcut only.
            //and print the final result.
            //Modulus by 2 will tell you if a number is even or not.
            //If there is a remainder (1) then the number is odd:
            //===========================   INSERT CODE BELOW   ========================================



            Console.WriteLine();
            //Standard mathematical ORDER OF OPERATIONS sequence (PEMDAS)
            //applies with all operators in a mathematical expression.
            //===========================   INSERT CODE BELOW   ========================================



        }//end Main()
    }//end Class
}//end Namespace
