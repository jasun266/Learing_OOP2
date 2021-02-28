using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
	class Account
	{

		private int accountNumber;
		private string accountName;
		private double balance;
		//private Address address;

		public Account(string accountName, double balance, Address address)
		{
			//this.accountNumber // auto generate
			this.accountName = accountName;
			this.balance = balance;
			this.address = address;
		}

		public void Withdraw(double amount)
		{

		}

		public void Deposit(double amount)
		{

		}

		public void Transfer(int receiver, double amount)
		{

		}

		public void ShowAccountInformation(double amount)
		{

		}

	}

}
