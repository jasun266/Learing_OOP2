using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
	struct Address 
	{
		private String readNo;
		private String houseNo;
		private String city;
		private String country;

		public Address(String readNo, string houseNo, string city, String country)
		{
			this.readNo		= readNo;
			this.houseNo	= houseNo;
			this.city		= city;
			this.country	= country;

		}
		public string GetAddress ()
		{
			return this.readNo+" "+this.houseNo+" "+this.city+ " "+this.country;
		}
	}
	class Account
	{

		private int accountNumber;
		private string accountName;
		private double balance;
		private Address address;

		public Account(string accountName, double balance, Address address)
		{
			this.accountNumber	 = accountNumber; // auto generate
			this.accountName	 = accountName;
			this.balance		 = balance;
			this.address		 = address;
		}

		public int AccountNumber 
		{
			set { this.accountNumber = value; }
			get { return this.accountNumber; }
		}

		public string AccountName 
		{
			set { this.accountName = value; }
			get { return this.accountName; }
		}
		public double Balance 
		{
			set { this.balance = value; }
			get { return this.balance; }
		}
		public Address Address 
		{
			set { this.address = value; }
			get { return this.address; }
		}

		public void Withdraw(double amount)
		{
			if (this.balance - amount >500 )
			{
				this.balance = this.balance - amount;
				Console.WriteLine("{0} wihdraw successful", amount);
			}
			else 
			{
				Console.WriteLine("insufficient account balance....");
			}
		}

		public void Deposit(double amount)
		{
			this.balance = this.balance + amount;
			Console.WriteLine("{0} amount has been added", amount);
		}

		public void Transfer(int receiver, double amount)
		{
			if(this.balance - amount > 500 && this.accountNumber == receiver) 
			{
				this.balance = this.balance - amount;
				Console.WriteLine("{0} TK has been transfer", amount);
			}
		}

		public void ShowAccountInformation()
		{
			Console.WriteLine("Account ID               --> {0}", this.accountNumber);
            Console.WriteLine("Account holder's Name    --> {0}", this.accountName);
            Console.WriteLine();
            Console.WriteLine("Owner's address ");
           // this.Address();
            Console.WriteLine();
            Console.WriteLine("Current account balance  --> {0}", this.Balance);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---  ---  ---  ---  ---  ---  ---  ---  ---  ---  ---  ");
		}

	}

}
