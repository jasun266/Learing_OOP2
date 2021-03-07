using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
	class CheckingAccount : Account
	{
        internal CheckingAccount(int accountNumber, string accountName, double balance, Address address) : base(accountNumber, accountName, balance, address)
        {

        }



        public override bool Withdraw(double withdrawAmount)
        {

            if (this.Balance - withdrawAmount >=0)
            {
                this.Balance = this.Balance - withdrawAmount;
                Console.WriteLine("{0} taka has been withdrawn.", withdrawAmount);
                //  this.ShowInformation();
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
        }
    }
}
