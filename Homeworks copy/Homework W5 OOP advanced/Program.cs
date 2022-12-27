using Homework_W5_OOP_advanced.Exercise1;
using Homework_W5_OOP_advanced;
using System;

BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.WithDraw(200);

Console.WriteLine(myAccount.GetBalance()); 

List<Transaction> transactions = myAccount.GetTransactionHistory();


foreach (Transaction transaction in transactions)
{
    Console.WriteLine($"{transaction.Timestamp}: {transaction.Type} ${transaction.Amount}");
}


myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Jane Smith";

Console.WriteLine(myAccount.AccountNumber); 
Console.WriteLine(myAccount.AccountHolder); 