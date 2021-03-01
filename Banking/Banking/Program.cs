using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
	class Program
	{
		static void Main(string[] args)
		{
			//Bank newBank = new Bank("DBBL");
			//newBank.AddAccount(new Account(newBank.count, "Jasun", 500, new Address("1A", "TA-171", "Dhaka", "Bangladesh")));
			Bank.bankName = "DBBL";
			Bank.StartSystem();
		}
	}
}
