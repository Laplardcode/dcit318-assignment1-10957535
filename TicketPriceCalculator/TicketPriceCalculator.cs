﻿using System;

class ticketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        decimal ticketPrice = 10;

        if (age <= 12 || age >= 65)
        {
            ticketPrice = 7;
        }

        Console.WriteLine("The ticket price is: GHC" + ticketPrice);
    }
}