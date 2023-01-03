using System;
namespace Homework_W5_OOP_advanced
{
	public class BankAccountEx5
	{
		private int accountNumber;
		private string accountHolder;
		private double balance;
		public int AccountNumber { get; set; }
		public string AccountHolder { get; set; }
		public double Balance { get; set; }

		public BankAccountEx5(int AccountNumber,string AccountHolder,double Balance)
		{
			this.AccountHolder = AccountHolder;
			this.AccountNumber = AccountNumber; 
            if (Balance > 0)
			{
				this.Balance = Balance;
                balance = Balance;
            }
			else
			{
				throw new ArgumentException("Please note that the balance can't be negative; try again");
			}
			Bank.NumAccounts++;
        }

		public double Deposit (double amount)
		{
			if (amount>0)
			{
				return Balance += amount;
			}
			else
			{
                throw new ArgumentException("Please note that the amount can't be negative; try again");
            }
		}

		public double WithDraw(double amount)
		{
			if (Balance - amount < 0)
			{
                throw new ArgumentException("Please note that the Balance of the account will be negative; cannot proceed further on");
            }
			else
			{
                return Balance -= amount;
            }
		}

		public double GetInterest()
		{
            return Bank.CalculateInterest(Balance);
        }
	}
}

