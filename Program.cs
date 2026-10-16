using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // DSA Activity 5.3 - Buduhan, Sharmie Ann A.

        Stack<int> playerA = new Stack<int>();
        Stack<int> playerB = new Stack<int>();

        int[] numbersA = { 2, 7, 8, 1, 6, 4, 3, 2, 8, 9 };
        int[] numbersB = { 8, 1, 9, 3, 6, 5, 9, 9, 4, 3 };

        foreach (int n in numbersA)
            playerA.Push(n);

        foreach (int n in numbersB)
            playerB.Push(n);

        Console.WriteLine("WELCOME TO My SIMPLE GAME program.");
        Console.WriteLine();

        Console.WriteLine("Player A: " + string.Join(" ", numbersA));
        Console.WriteLine("Player B: " + string.Join(" ", numbersB));
        Console.WriteLine();

        int match = 1;

        while (playerA.Count > 0 && playerB.Count > 0)
        {
            int a = playerA.Pop();
            int b = playerB.Pop();

            Console.WriteLine("Match " + match + ":");
            Console.WriteLine(a + " vs " + b);

            if (a > b)
            {
                playerB = RemoveNumber(playerB, b);
                Console.WriteLine("Player A Win");
            }
            else if (a < b)
            {
                playerA = RemoveNumber(playerA, a);
                Console.WriteLine("Player B Win");
            }
            else
            {
                Console.WriteLine("Rematch");
            }

            Console.WriteLine();
            match++;
        }

        Console.WriteLine("Final Result:");
        Console.WriteLine("Player A: " + string.Join(" ", playerA.ToArray()));
        Console.WriteLine("Player B: " + string.Join(" ", playerB.ToArray()));
        Console.WriteLine();

        if (playerA.Count > playerB.Count)
            Console.WriteLine("Player A Win");
        else if (playerB.Count > playerA.Count)
            Console.WriteLine("Player B Win");
        else
            Console.WriteLine("Draw");

        Console.WriteLine();
        Console.WriteLine("Thank you for using the program.");
    }

    static Stack<int> RemoveNumber(Stack<int> stack, int number)
    {
        Stack<int> temp = new Stack<int>();
        bool removed = false;

        while (stack.Count > 0)
        {
            int n = stack.Pop();

            if (!removed && n == number)
                removed = true;
            else
                temp.Push(n);
        }

        Stack<int> result = new Stack<int>();

        while (temp.Count > 0)
            result.Push(temp.Pop());

        return result;
    }
}

