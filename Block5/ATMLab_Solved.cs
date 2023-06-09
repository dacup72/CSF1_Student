using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
	internal class ATMLabSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Gringotts ATM");

			bool isAccountCorrect = false;
			string accountNum = "1234";
			while (isAccountCorrect == false)
			{
				Console.Write("\nEnter your account number: ");
				string userAcctNum = Console.ReadLine();

				if (userAcctNum == accountNum)
				{
					isAccountCorrect = true;
				}
				else
				{
					Console.WriteLine("\nThat did not match our records. Please try again.\n\n");
				}
			}

			bool isPinCorrect = false;
			int pinAttempts = 1;
			string pin = "100";
			while (isPinCorrect == false && isAccountCorrect == true && pinAttempts <= 3)
			{
				Console.Write("\nEnter your account pin: ");
				string userPin = Console.ReadLine();

				if (userPin == pin)
				{
					isPinCorrect = true;
				}
				else if (pinAttempts < 3)
				{
					Console.WriteLine("\nThat did not match our records. Please try again.\n\n");
					pinAttempts++;
				}
				else
				{
					Console.WriteLine("Too many incorrect pin numbers entered. Program exiting.");
					pinAttempts++;
				}
			}

			bool repeat = true;
			decimal balance = 0;

			while (repeat == true && isAccountCorrect == true && isPinCorrect == true)
			{
				Console.WriteLine("Select an option: B) Balance D) Deposit W) Withdraw X) Exit");
				string userChoice = Console.ReadLine().ToUpper();

				switch (userChoice)
				{
					case "B":
					case "BALANACE":
						Console.WriteLine("You have {0:c} in your account.\n\n", balance);

						Console.WriteLine("Would you like to perform another action: (Y/N)");
						string userSelection = Console.ReadLine().ToUpper();
						if (userSelection == "N" || userSelection == "NO")
						{
							Console.WriteLine("Thank you for using Gringotts for your magical banking.");
							repeat = false;
						}
						else
						{
							Console.WriteLine("Returning to main menu....\n\n");
						}
						break;
					case "D":
					case "DEPOSIT":
						Console.Write("\nHow much would you like to deposit: $");
						decimal deposit = decimal.Parse(Console.ReadLine());
						balance += deposit;
						Console.WriteLine("{0:c} has been deposited in your account. Your balance is now {1:c}.\n\n", deposit, balance);

						Console.WriteLine("Would you like to perform another action: (Y/N)");
						string userSelection2 = Console.ReadLine().ToUpper();
						if (userSelection2 == "N" || userSelection2 == "NO")
						{
							Console.WriteLine("Thank you for using Gringotts for your magical banking.");
							repeat = false;
						}
						else
						{
							Console.WriteLine("Returning to main menu....\n\n");
						}
						break;
					case "W":
					case "WITHDRAW":
						Console.Write("\nHow much would you like to withdraw: $");
						decimal withdraw = decimal.Parse(Console.ReadLine());
						balance -= withdraw;
						Console.WriteLine("{0:c} has been withdrew from your account. Your balance is now {1:c}.\n\n", withdraw, balance);

						Console.WriteLine("Would you like to perform another action: (Y/N)");
						string userSelection3 = Console.ReadLine().ToUpper();
						if (userSelection3 == "N" || userSelection3 == "NO")
						{
							Console.WriteLine("Thank you for using Gringotts for your magical banking.");
							repeat = false;
						}
						else
						{
							Console.WriteLine("Returning to main menu....\n\n");
						}
						break;
					case "E":
					case "EXIT":
					case "X":
						Console.WriteLine("Thank you for using Gringotts for your magical banking.");
						repeat = false;
						break;
					default:
						Console.WriteLine("Input not recognized.\n");
						break;
				}
			}

		}
	}
}
