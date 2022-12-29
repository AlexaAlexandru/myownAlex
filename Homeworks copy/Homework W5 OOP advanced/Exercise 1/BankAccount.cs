using System;
using System.Linq;
namespace Homework_W5_OOP_advanced.Exercise1
{
	public class BankAccount
	{
		public int AccountNumber { get;  set; }
		public string AccountHolder { get;  set; }
		public decimal balance;
		private decimal Balance
		{
			get { return this.balance; }
			set { this.balance = value; }
		}

        public List<string> Transactions { get; set; }

        public BankAccount(int AccountNumber,string AccountHolder,decimal balance)
		{
			this.AccountHolder = AccountHolder;
			this.AccountNumber = AccountNumber;
			this.balance = balance;
            this.Transactions = new List<string>();
        }

        public void Deposit(decimal amount)
		{
            Balance += amount;
			/*
			transaction.Type = "Deposited";
            transaction.Timestamp= DateTime.Now;
			transaction.Amount = amount;
			string messageDeposit = $"{transaction.Type} {amount} on the {transaction.Timestamp}";
			Transactions.Add(messageDeposit);
			*/
        }
        

		


        public void WithDraw(decimal amount)
		{ 
            Balance -= amount;


            /*
             transactions.Type = "Withdrawed";
            transactions.Timestamp = DateTime.Now;
            transactions.Amount = amount;
			*/
			

        }

      

        public decimal GetBalance()
		{
			return Balance;
		}

		public List<string> GetTransactionHistory()
		{
			return Transactions;
        }
		/*

		public List<Transaction> GetTransactionHistory()
		{
			return listOfTransactions.OrderBy(o => o.Timestamp).ToList();
		}
		*/

    }
}

