using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Block3
{
	class InputParseConvertSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Capturing input, parsing and converting");

			#region Input/Output Notes
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
			#endregion

			string firstName = "Doctor", lastName = "Who";

			Console.Write(firstName);
			Console.Write(" " + lastName);
			//NO line break after a Console.Write() 
			Console.WriteLine(" - and now a line break....");
			//WriteLine() adds a break AFTER the output

			Console.WriteLine();//creates a blank line


			//ReadLine() lets a user type input, however, you must
			//capture that input or it is lost.

			Console.ReadLine();

			#region ReadLine Notes

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

			#endregion

			//Step 1
			Console.Write("What is your name? ");

			//Step 2 & 3:
			string userName = Console.ReadLine();

			//now use that info
			Console.WriteLine("Hello, " + userName + "!");

			//An example of using the info immediately. We can
			//NOT reuse the info from the below ReadLine():

			//step 1
			Console.Write("What is your quest?");

			//step 2, let them type and this time we will use that info
			//immediately
			Console.WriteLine(Console.ReadLine() +
				" is a silly quest....");

			//Ask the user for their favourite colour. Tell them
			//their colour back and what you think of it. Use the
			//name they gave you above in your response.

			//Step 1
			Console.WriteLine("What is your favorite color?");

			//Step 2
			string userColor = Console.ReadLine();

			//use it
			Console.WriteLine(userName + ", did you really choose " +
				userColor + "?? Lame-o");


			//another example
			Console.WriteLine("What planet are you from?");
			string userPlanet = Console.ReadLine();

			//String formatting uses 0-based counting for indexes
			//and puts the variables into those spots.
			//Think of it like placeholders.
			Console.WriteLine("{0} is great, {1}!", userPlanet, userName);
			//! break a CPH and show system.formatexception error

			//Since ReadLine() always returns a string we will
			//need to do extra work to use that information as 
			//another datatype. One option for this is called Parsing.
			//SYNTAX: datatype.Parse(stringValue)

			//Parsing Example
			Console.Write("Enter your age: ");
			string userAge = Console.ReadLine();
			int age = int.Parse(userAge);//Now we can do math with the input!
			int yearsTo100 = 100 - age;

			Console.WriteLine("Only {0} more years until you are 100!",
				yearsTo100);

			//step 1, give them instructions
			Console.WriteLine("How much do you want to make per year? "
				+ "Decimal values are OK, no $ symbols allowed.");

			//step 2 & 3, catch input and store it
			string salaryString = Console.ReadLine();

			//now parse it to a numeric type
			decimal salary = decimal.Parse(salaryString);

			//String Interpolation
			//Like string formatting, string interpolation uses placeholders.
			//Unlike formatting, however, you pass the information you want
			//plugged in directly into the placeholder:

			Console.WriteLine($"Well, {salary * .35m} will go to taxes...");

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
			Console.WriteLine("How many times have you been smuggled " +
				"through Imperial lines by Solo & Chewie shipping?");

			//step 2 & 3: catch the input and store it
			string timesSmuggledString = Console.ReadLine();

			//Parsing
			//short timesSmuggled = short.Parse(timesSmuggledString);

			//Now using Convert (essentially the same as above)
			short timesSmuggled = Convert.ToInt16(timesSmuggledString);

			Console.WriteLine("You have {0} more trips to get your " +
				"free lightsaber.",
				10 - timesSmuggled);

		} //end method
	}//end class
}//end namespace
