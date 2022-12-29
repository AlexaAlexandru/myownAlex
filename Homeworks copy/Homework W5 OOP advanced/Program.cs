﻿using Homework_W5_OOP_advanced.Exercise1;
using Homework_W5_OOP_advanced;
using Homework_W5_OOP_advanced.Exercise2;
using Homework_W5_OOP_advanced.Exercise3;
using System;

Console.WriteLine("----Ex 1----");
BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);



myAccount.Deposit(500);
myAccount.WithDraw(200);

Console.WriteLine(myAccount.GetBalance());

/*
List<string> transactions = myAccount.GetTransactionHistory();

foreach (var transaction in transactions)
{
    Console.WriteLine($"{transaction}");
}
*/

myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Jane Smith";

Console.WriteLine(myAccount.AccountNumber); 
Console.WriteLine(myAccount.AccountHolder);

Console.WriteLine("----Ex 2----");

Book book = new Book("The Great Gatsby", "F.Scott Fitzgerald", 180);

Console.WriteLine(book.GetTitle()); 
Console.WriteLine(book.GetAuthor()); 
Console.WriteLine(book.GetPageCount()); 
Console.WriteLine(book.GetCurrentPage()); 

book.NextPage();
Console.WriteLine(book.GetCurrentPage()); 

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage()); 

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage()); 

book.Title = "The Great Gatsby (Revised Edition)";
Console.WriteLine(book.GetTitle());
book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
Console.WriteLine(book.GetAuthor());

Console.WriteLine("----Ex 3----");

Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);

List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color + ": " + shape.Area);
}

double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}

Console.WriteLine("Total perimeter: " + totalPerimeter + " inches");

Console.WriteLine("----Ex 4----");

Manager manager = new Manager("John Doe", 35, 50_000, Department.IT);
Developer developer = new Developer("Jane Smith", 28, 30_000, new List<string> { "C#", "Javascript" }, false);

Console.WriteLine(manager.CalculateBonus());
Console.WriteLine(developer.CalculateBonus());

Console.WriteLine(manager.GetContactInfo());

//Console.WriteLine(developer.GetContactInfo());

Console.WriteLine("----Ex 5----");

BankAccountEx5 account1 = new BankAccountEx5(123456, "John Doe",1000);
BankAccountEx5 account2 = new BankAccountEx5(654321, "Jane Smith",2000);

account1.Deposit(500);
account2.WithDraw(1000);

Console.WriteLine(account1.Balance);
Console.WriteLine(account2.Balance);

Console.WriteLine(account1.GetInterest());
Console.WriteLine(account2.GetInterest());

Console.WriteLine(Bank.NumAccounts);

Console.WriteLine("----Ex 6----");

IShape circle = new CircleEx6(5);
IShape rectangle = new RectangleEx6(10, 5);

Console.WriteLine(circle.CalculateArea());
Console.WriteLine(rectangle.CalculateArea());

Console.WriteLine(circle.CalculateArea("Square feet"));
Console.WriteLine(rectangle.CalculateArea("Square meters"));

Icolor circleColor = (Icolor)circle;
circleColor.Color = "Red";

Icolor rectangleColor = (Icolor)rectangle;
rectangleColor.Color = "Blue";

Console.WriteLine(circleColor.Color);
Console.WriteLine(rectangleColor.Color);

Console.WriteLine("----Ex 7----");