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

        private List<Transaction> listOfTransactions = new List<Transaction>();
        public Transaction transactions;

		public BankAccount(int AccountNumber,string AccountHolder,decimal balance)
		{
			this.AccountHolder = AccountHolder;
			this.AccountNumber = AccountNumber;
			this.balance = balance;
		}



		public void Deposit (decimal amount)
		{
            
            Balance += amount;
            transactions.Type = "Deposited";
			transactions.Timestamp= DateTime.Now;
			transactions.Amount = amount;
			listOfTransactions.Add(Deposit());

        }

        private Transaction Deposit()
        {
            throw new NotImplementedException();
        }

        public void WithDraw(decimal amount)
		{
            listOfTransactions.Add(new Transaction());
            Balance -= amount;
            transactions.Type = "Withdrawed";
            transactions.Timestamp = DateTime.Now;
            transactions.Amount = amount;
            

        }
		public decimal GetBalance()
		{
			return Balance;
		}

		public List<Transaction> GetTransactionHistory()
		{
			return listOfTransactions.OrderBy(o => o.Timestamp).ToList();
		}


    }
}

