using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Block3
{
    class InputParseConvertUnsolved
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capturing input, parsing and converting");


            /*
             * There are 2 main options for output in console:
             * Write() and WriteLine()
             * 
             * WriteLine() adds a line break after your output.
             * Write() does not.
             * 
             * There are 3 options for Input in console:
             * 
             * Read() - Only takes 1 keystroke of input and stores the
             * ascii value of the key.
             * ReadKey() - Similar idea, but captures the key's
             *              character value 
             * ReadLine() - Most common. It allows the user to input
             * something and reads the input as a string after they
             * hit enter.
             *  
             * The important part is capturing or using the information
             * they gave you.
             * */


            string firstName = "Doctor", lastName = "Who";

            //NO line break after a Console.Write() 
            //===========================   INSERT CODE BELOW   ========================================


            //WriteLine() adds a break AFTER the output
            //===========================   INSERT CODE BELOW   ========================================



            Console.WriteLine();//creates a blank line

         
            //ReadLine() lets a user type input, however, you must
            //capture that input or it is lost.

            Console.ReadLine();


			/*
             * You cannot put any code inside the parens of the 
             * ReadLine(). Using ReadLine() by itself without storing
             * the input or using it immediately results in the input 
             * being lost.
             * Using ReadLine()
             * 
             * Step 1 - Explain to the user what to type!
             *          They cannot read your mind.....
             *          
             * Step 2 - Allow them to type by using
             *          Console.ReadLine()
             *          
             * Step 3 - Capture their input into a variable and store it 
             *          or use it immediately
             */



			//Step 1
			// Output "What is your name?"
			//===========================   INSERT CODE BELOW   ========================================



			//Step 2 & 3
			// Prompt user input and capture their answer in a variable
			//===========================   INSERT CODE BELOW   ========================================


			//now use that info to output it to the console
			//===========================   INSERT CODE BELOW   ========================================


			//An example of using the info immediately. We can
			//NOT reuse the info from the below ReadLine():

			//step 1
			// Output "What is your quest?"
			//===========================   INSERT CODE BELOW   ========================================


			//step 2, let them type and this time we will use that info
			//immediately to output their answer to the console
			//===========================   INSERT CODE BELOW   ========================================



			//Ask the user for their favourite colour. Tell them
			//their colour back and what you think of it. Use the
			//name they gave you above in your response.

			//Step 1
			// Output "What is your favorite color?"
			//===========================   INSERT CODE BELOW   ========================================


			//Step 2
			// Record users answer
			//===========================   INSERT CODE BELOW   ========================================


			//use it
			//===========================   INSERT CODE BELOW   ========================================



			//another example
			// Ask and record the users answer to "What planet are you from?"
			//===========================   INSERT CODE BELOW   ========================================



            //String formatting uses 0-based counting for indexes
            //and puts the variables into those spots.
            //Think of it like placeholders.
            //===========================   INSERT CODE BELOW   ========================================




            //Since ReadLine() always returns a string we will
            //need to do extra work to use that information as 
            //another datatype. One option for this is called Parsing.
            //SYNTAX: datatype.Parse(stringValue)

            //Parsing Example
            // Prompt and record the users age
            //===========================   INSERT CODE BELOW   ========================================


			// Now convert the input to an int
			//===========================   INSERT CODE BELOW   ========================================


			//Now we can do math with the input!
            //===========================   INSERT CODE BELOW   ========================================



            // Another example
            // Ask the user how much they want to make per year
            //step 1, give them instructions
            //===========================   INSERT CODE BELOW   ========================================


            //step 2 & 3, catch input and store it
            //===========================   INSERT CODE BELOW   ========================================


            //now parse it to a numeric type
            //===========================   INSERT CODE BELOW   ========================================


            //String Interpolation
            //Like string formatting, string interpolation uses placeholders.
            //Unlike formatting, however, you pass the information you want
            //plugged in directly into the placeholder:
            // Using string interpolation subtract 35% tax from the users salary
            //===========================   INSERT CODE BELOW   ========================================


            //True names:
            /*
             * All of the data types we have used up to this point are
             * "intrinsic" or "simple" datatypes that have their own
             * C# reserved keyword associated with them. In reality
             * the keyword is just an alias for class that exists
             * by default in the framework. You 
             * can use either the alias or the true name:
             * 
             * byte = Byte
             * short = Int16
             * int = Int32
             * long = Int64
             * decimal = Decimal
             * double = Double
             * float = Single
             * string = String
             * bool = Boolean
             * char = Char
             */

            //Example:
            int x = 1;
            Int32 y = 2;

            //Convert is another option for changing the datatype
            //of information. It works similar to Parse(), but the
            //syntax is different:
            //Convert.ToTRUENAME(valueToConvert)
            //Example: Convert.ToInt32(userAge)

            //Ask the user how many times they have been smuggled.
            //They get a free light saber after 10 trips!

            //step 1: Give the user instructions
            //===========================   INSERT CODE BELOW   ========================================



            //step 2 & 3: catch the input and store it
            //===========================   INSERT CODE BELOW   ========================================



            //Parsing
            // Parse the answer into a short
            //===========================   INSERT CODE BELOW   ========================================


            //Now using Convert (essentially the same as above)
            //===========================   INSERT CODE BELOW   ========================================


            // Output the answer
            //===========================   INSERT CODE BELOW   ========================================



        } //end method
    }//end class
}//end namespace
