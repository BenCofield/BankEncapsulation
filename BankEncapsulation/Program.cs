using System;
using BankEncapsulation;


var account1 = new BankAccount();
while (true)
{
    
    Console.WriteLine("ATM\n" +
                      "----------\n" +
                      "1. Deposit\n" +
                      "2. See Balance\n" +
                      "3. Exit\n" +
                      "----------\n" +
                      "Choose from options: ");
    var selection = Console.ReadLine();
    switch (selection)
    {
        case "1":
            Console.WriteLine("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());
            account1.Deposit(depositAmount);
            break;
        case "2":
            Console.WriteLine($"Your balance is ${account1.GetBalance()}.");
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Invalid input");
            break;
    }


}