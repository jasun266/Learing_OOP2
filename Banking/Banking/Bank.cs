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

		public static void AddAccount(int type)
		{

			if (type == 1)
			{
				int accountNumberAutogenerate = count;

				Console.WriteLine("Enter Your name- ");
				string accountName = Convert.ToString(Console.ReadLine());

				Console.WriteLine("Enter Your Bank Balance - ");
				double balance = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Enter Your road NO - ");
				string roadNO = Console.ReadLine();

				Console.WriteLine("Enter Your House NO - ");
				string houseNo = Console.ReadLine();

				Console.WriteLine("Enter Your city Name - ");
				string city = Console.ReadLine();

				Console.WriteLine("Enter Your county name - ");
				string country = Console.ReadLine();


				myBank[count] = new SavingsAccounts(accountNumberAutogenerate, accountName, balance, new Address(roadNO, houseNo, city, country));



			}

			else
			{
				int accountNumberAutogenerate = count;

				Console.WriteLine("Enter Your name- ");
				string accountName = Convert.ToString(Console.ReadLine());

				Console.WriteLine("Enter Your Bank Balance - ");
				double balance = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Enter Your road NO - ");
				string roadNO = Console.ReadLine();

				Console.WriteLine("Enter Your House NO - ");
				string houseNo = Console.ReadLine();

				Console.WriteLine("Enter Your city Name - ");
				string city = Console.ReadLine();

				Console.WriteLine("Enter Your county name - ");
				string country = Console.ReadLine();


				myBank[count] = new CheckingAccount(accountNumberAutogenerate, accountName, balance, new Address(roadNO, houseNo, city, country));


			}



			Console.WriteLine();
			Console.WriteLine("		Account created successfully. ");
			Console.WriteLine();
			count++;
		}


		public static void Transfer(int senderId, int receiverId, double amount)
		{
			int senderIndex = SearchIndividualAccount(senderId);
			int receiverIndex = SearchIndividualAccount(receiverId);

			if (myBank[senderIndex].Withdraw(amount))
			{
				myBank[receiverIndex].Deposit(amount);
			}
			else
			{
				Console.WriteLine("Transfer Incomplete. ");
			}
		}



		

		public static void Transaction(int transactionType)
		{
			int accountId;


			if (transactionType == 1)
			{


				Console.WriteLine();
				Console.WriteLine("		Depositing Money..........");
				Console.WriteLine();

				Console.WriteLine("Enter your account Number - ");
				accountId = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine();
				Console.WriteLine("Enter how much money do you want to deposit - ");
				double depositAmount = Convert.ToDouble(Console.ReadLine());
				myBank[accountId].Deposit(depositAmount);
				Console.WriteLine();
				Console.WriteLine("     Deposit successfull......");
				Console.WriteLine();

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
				Console.WriteLine();
				Console.WriteLine(".....withdraw successfull.....");
				Console.WriteLine();
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

				Transfer(sendersId, receiversId, amount);
				Console.WriteLine();
				Console.WriteLine();


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
		public static int SearchIndividualAccount(int id)
		{
			short index = 1;
			bool flag = false;
			while (index < count)
			{
				if (myBank[index] != null)
				{
					if (myBank[index].AccountNumber == id)
					{
						//	Console.WriteLine("Account Found. ");
						flag = true;
						return index;
					}
				}

				index++;
			}
			if (!flag)
				Console.WriteLine("Account doesn't exists. ");
			return -1;
		}


		public static void StartSystem()
		  {

			bool keepLooping = true;

			while (keepLooping)
			{
				Console.WriteLine("Select option ");
				Console.WriteLine();

				Console.WriteLine("1. Add new Account ");
				Console.WriteLine("2. Transaction ");
				Console.WriteLine("3. Show account ");
				Console.WriteLine("4. exit ");
				Console.WriteLine();
				Console.Write("-->  ");

				ushort caseSwitch = (ushort)Convert.ToInt16(Console.ReadLine());

				switch (caseSwitch)
				{
					case 1:
						Console.WriteLine();
						Console.WriteLine("Adding new Account ");
						Console.WriteLine();
						Console.WriteLine("Which type of account do you want to create?");
						Console.WriteLine("Press 1 for savings account ");
						Console.WriteLine("Press 2 for checking account ");

						Console.WriteLine();
						int type = Convert.ToInt32(Console.ReadLine());

						AddAccount(type);
						break;
					case 2:
						Console.WriteLine("Which type of account do you want to create?");
						Console.WriteLine("Press 1 for deposit ");
						Console.WriteLine("Press 2 for   withdraw");
						Console.WriteLine("Press 3 for Transfering money ");

						Console.WriteLine();
						int transactionType = Convert.ToInt32(Console.ReadLine());

						Transaction(transactionType);
						break;
					
					case 3:
						Console.WriteLine();
						Console.WriteLine("		Searching an  Account ");
						Console.WriteLine();

						Console.WriteLine("Enter your account Id - ");
						int accountId = Convert.ToInt32(Console.ReadLine());

						 int index = SearchIndividualAccount(accountId);
						Console.WriteLine("Account {0} was found ", accountId);

						Console.WriteLine();
						Console.WriteLine();
						if (index != -1)
						{
							myBank[index].ShowAccountInformation();
						}

						break;
						
					case 5:
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



	}

		
}
