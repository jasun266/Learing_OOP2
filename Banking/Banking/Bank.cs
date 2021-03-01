using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
	class Bank
	{
		public static string bankName;
		public static Account[] myBank = new Account[100];
		public static int count = 1;

		public Bank(string bankName ) 
		{
			bankName = bankName;
		}

		public static void AddAccount(Account account)
		{
			myBank[count] = account;
			count++;
		}
		

		public  static void  DeleteAccount(int accountNumber ) 
		{
			
				myBank[accountNumber] = null;
				Console.WriteLine("{0} no Account deleted.\n", accountNumber);
		}

		public static void Transaction(int transactionType)
		{
			int accountId;


			if (transactionType == 1)
			{


				Console.WriteLine();
				Console.WriteLine("		Depositing Money");
				Console.WriteLine();

				Console.WriteLine("Enter your account Number - ");
				accountId = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine();
				Console.WriteLine("Enter how much money do you want to deposit - ");
				double depositAmount = Convert.ToDouble(Console.ReadLine());
				myBank[accountId].Deposit(depositAmount);

			}

			else if (transactionType == 2)
			{
				Console.WriteLine();
				Console.WriteLine("		Withdrawing Money");
				Console.WriteLine();

				Console.WriteLine("Enter your account Id - ");
				accountId = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter how much money do you want to withdraw - ");
				double amount = Convert.ToDouble(Console.ReadLine());
				myBank[accountId].Withdraw(amount);
				Console.WriteLine("withdraw successfull");
			}

			else
			{
				Console.WriteLine();
				Console.WriteLine("		Transfering money...");
				Console.WriteLine();

				Console.WriteLine("Enter sender account Id - ");
				int sendersId = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter receivers account Id - ");
				int receiversId = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter amount - ");
				double amount = Convert.ToDouble(Console.ReadLine());

				myBank[receiversId].Transfer(sendersId, receiversId, amount);
				Console.WriteLine();
				Console.WriteLine();


			}
			}
		

		  public static void StartSystem()
		  {

			bool keepLooping = true;

			while (keepLooping)
			{
				Console.WriteLine("Select option ");
				Console.WriteLine();

				Console.WriteLine("1. Add new Account ");
				Console.WriteLine("2. Delete  Account ");
				Console.WriteLine("3. Transaction ");
				Console.WriteLine("4. Show all account ");
				Console.WriteLine("5. exit ");
				Console.WriteLine();
				Console.Write("-->  ");

				ushort caseSwitch = (ushort)Convert.ToInt16(Console.ReadLine());

				switch (caseSwitch)
				{
					case 1:
						Console.WriteLine();
						Console.WriteLine("New Account added");
						AddAccount(new Account(count, "Jasun", 500, new Address("1A", "TA-171", "Dhaka", "Bangladesh"))); 
						AddAccount(new Account(count, "Pronoy", 500, new Address("2A", "A-18", "CTG", "Bangladesh"))); 
						AddAccount(new Account(count, "Didar", 500, new Address("3B", "I-91", "Dhaka", "Bangladesh"))); 
						break;
					
					case 2:
						Console.WriteLine();
						Console.WriteLine("		Deleting account");
						Console.WriteLine();

						Console.WriteLine("Enter your account Id - ");
						int accountNumber = Convert.ToInt32(Console.ReadLine());

						DeleteAccount(accountNumber);

						break;
					case 3:
						Console.WriteLine("Which type of account do you want to create?");
						Console.WriteLine("Press 1 for deposit ");
						Console.WriteLine("Press 2 for   withdraw");
						Console.WriteLine("Press 3 for Transfering money ");

						Console.WriteLine();
						int transactionType = Convert.ToInt32(Console.ReadLine());

						Transaction(transactionType);
						break;
					
					case 4:
						Console.WriteLine();
						Console.WriteLine("		Showing  All  Account  Information ");
						Console.WriteLine();
						Console.WriteLine();
						PrintAccountDeails();

						break;
						
					case5:
						Console.WriteLine();
						Console.WriteLine("Exitting the System ");
						keepLooping = false;

						break;

					default:
						Console.WriteLine();
						Console.WriteLine("		PLEASE TRY AGAIN");
						break;
				}
			}
		}


		private static void PrintAccountDeails()
		{
			short index = 1;
			while (index < count)
			{
				if (myBank[index] != null)
				{
					myBank[index].ShowAccountInformation();
					Console.WriteLine();
				}
				index++;
			}
		}

	}

		
	}
