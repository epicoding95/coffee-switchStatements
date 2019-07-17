using System;

class Program
{
    static void Main()
    {
        int TotalCoffeeCost = 0;
        Start:
   Console.WriteLine("Please select your coffee size: 1 -small,2 -medium,3 -large");
   int userChoice = int.Parse(Console.ReadLine());

   switch(userChoice)
   {
       case 1:
       TotalCoffeeCost += 1;
       break;
        case 2:
       TotalCoffeeCost += 2;
       break;
        case 3:
       TotalCoffeeCost += 3;
       break;

       default: 
       Console.WriteLine("your choice {0} invalid", userChoice);
       goto Start;

   }
   Decide:
   Console.WriteLine("Do you want to buy another coffee- Yes or No?");
    string userDecision = Console.ReadLine();

    switch(userDecision.ToUpper())
    {
        case "YES":
            goto Start;
            
        case "NO":
             break;

        default:
        Console.WriteLine("your choice {0} is invalid. please try again", userDecision);
         goto Decide;
        break;
    }
        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Your bill amount = {0}$", TotalCoffeeCost);
    }
}