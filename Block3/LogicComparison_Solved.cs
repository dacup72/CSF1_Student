using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Block3
{
	class LogicComparisonSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Logical and Comparison Operators");

			//Comparison Operators
			//"Relational" and "Equality" operators compare
			//2 different values and result in a bool answer of
			//true or false

			/*
             *  > is greater than
             *  < is less than
             *  >= is greater than or equal to
             *  <= is less than or equal to
             */

			int ceoPayGrade = 20;
			int mgrPayGrade = 12;
			int mailroomPayGrade = 2;

			bool isCeoPayHigher = ceoPayGrade > mgrPayGrade;
			Console.WriteLine("Is CEO greater than MGR? " +
				isCeoPayHigher);

			Console.WriteLine("Is MGR greater than CEO? " +
				(mgrPayGrade > ceoPayGrade));

			Console.WriteLine("Is mailroom less than or equal to CEO? "
		  + (mailroomPayGrade <= ceoPayGrade));

			//a single = sign is assignment so to test equality, we use ==
			Console.WriteLine("is MGR equal to CEO? " + (mgrPayGrade == ceoPayGrade));

			//for not equal we have to use !=. An exclamation mark in C# generally means NOT
			Console.WriteLine("Is MGR different than CEO? " + (mgrPayGrade != ceoPayGrade));

			//comparing strings...
			string b = "batman";
			string b2 = "BATMAN";

			Console.WriteLine("Is b equal to b2? " + (b == b2));
			//C# is a case sensitive language, so these are NOT equal

			//To explore something in intellisense, use a period
			Console.WriteLine("case INSENSITIVE, is b equal to b2? " +
				(b.ToUpper() == b2));
			//all methods (purple boxes in intellisense)
			//MUST have parens

			//Basic overview of C# Methods - A method
			//is a group of statements that together perform a task. 
			//Every C# program has at least one class with a method named Main.
			//() = Method

			//Logical operators combine two comparison operators or bool values and returns a bool.
			// && is used for AND
			// || is used for OR
			//They still compare two values, but they must both resolve to Boolean values.

			bool payComparison = ceoPayGrade > mailroomPayGrade && ceoPayGrade < mgrPayGrade;

			Console.WriteLine("Is CEO less than MGR AND greater than Mailroom? " + payComparison);

			Console.WriteLine("Is MGR greater than Mailroom AND CEO greater than MGR? " +
				(ceoPayGrade > mgrPayGrade && mgrPayGrade > mailroomPayGrade));

			Console.WriteLine("Is 15 less than 5 or equal to 15? " +
				(15 < 5 || '$' == 'a'));

			//you can use literal values or variables or any mixture of the two in your logical operators

		}//end Main()
	}//end class
}//end namespace
