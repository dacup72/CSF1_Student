using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class StringsRevisitedUnsolved
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings Revisited!!!");

            //You can use the ToString() to get the string version of any value from a variable of any datatype.
            //You call this method from the variable name.
            //This can be used to turn a value in any variable of any datatype into a string:
            int number = 42;

            // Convert number to string
            //===========================   INSERT CODE BELOW   ========================================



            //Another example:
            decimal someDecimal = 124154.2392m;
            //===========================   INSERT CODE BELOW   ========================================




            //In the console, it is useful for the ability to pass format specifiers to the ToString() to "format" numbers or dates
            //===========================   INSERT CODE BELOW   ========================================





            //let's show these with string formatting:
            //===========================   INSERT CODE BELOW   ========================================



            //String Interpolation:
            //===========================   INSERT CODE BELOW   ========================================




            //Escape sequences
            //Special codes used inside a string that ignore certain characters. In C# they begin with a \

            // \n creates a new line inside of a string
            //===========================   INSERT CODE BELOW   ========================================



            // \" escapes the " and allows it to be used as a character
            //===========================   INSERT CODE BELOW   ========================================



            // \\ to get a \ (you have to escape... the escape)
            //===========================   INSERT CODE BELOW   ========================================



            /* Making text easier to read on-screen with concatenation:
            * To create a longer string that is easy to read 
            * use concatenation
            */

            //verbatim character @
            //similar to escape but it captures ALL characters
            //LITERALLY

            //This includes spacing, but to show double quotes inside of a verbatim string, you have to use double double quotes
            //To start a verbatim string add @ before the double quotes
            //===========================   INSERT CODE BELOW   ========================================






            //verbatim is often used for file locations:
            //===========================   INSERT CODE BELOW   ========================================




            //We can format strings without Console.WriteLine():
            //This method is extremely useful, because it gives us a reusable string variable:
            //===========================   INSERT CODE BELOW   ========================================




        }//end Main()
    }//end Class
}//end Namespace
