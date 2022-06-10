// Created by: Lucas Tyman
// Created on: May 2022
//
// This program does division using subtraction.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function does division using subtraction
        int firstInteger;
        int secondInteger;
        int numberCountingDown;
        int answer = 0;

        // input
        Console.WriteLine("This program does division using subtraction");

        Console.WriteLine("");
        Console.Write("Please enter the first integer: ");
        firstInteger = Convert.ToInt32(Console.ReadLine());
        numberCountingDown = firstInteger;

        Console.WriteLine("");
        Console.Write("Please enter the second integer: ");
        secondInteger = Convert.ToInt32(Console.ReadLine());

        // process
        if ((firstInteger > 0) && (secondInteger > 0))
        {
            while (numberCountingDown >= secondInteger)
            {
                numberCountingDown = numberCountingDown - secondInteger;
                answer++;
            }
        }
        else if ((firstInteger < 0) && (secondInteger < 0))
        {
            numberCountingDown = Math.Abs(numberCountingDown);
            secondInteger = Math.Abs(secondInteger);
            while (numberCountingDown >= secondInteger)
            {
                numberCountingDown = numberCountingDown - secondInteger;
                answer++;
            }

            secondInteger = -Math.Abs(secondInteger);
        }
        else
        {
            numberCountingDown = Math.Abs(numberCountingDown);
            secondInteger = Math.Abs(secondInteger);
            while (numberCountingDown >= secondInteger)
            {
                numberCountingDown = numberCountingDown - secondInteger;
                answer++;
            }

            answer = -Math.Abs(answer);
        }

        Console.WriteLine("");
        Console.WriteLine(firstInteger + " ÷ " + secondInteger + " = " + answer + " R " + numberCountingDown);
        Console.WriteLine("\nDone.");
    }
}