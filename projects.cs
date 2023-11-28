using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

void Main()
{
    Console.WriteLine("Choose the homework: ");
    string homework = Console.ReadLine();
    switch (homework)
    {
        case "8":
            Console.WriteLine($"Lab {homework} - Stacks \n");
            Stacks_8.Show();
            break;
        case "9":
            Console.WriteLine($"Lab {homework} - Queues \n");
            break;
        case "10":
            Console.WriteLine($"Lab {homework} - BitArrays \n");
            BitArray_10.Show();
            break;
        case "11":
            Console.WriteLine($"Lab {homework} - Strings \n");
            Strings_11.Show();
            break;
        case "12":
            Console.WriteLine($"Lab {homework} - BitArrays \n");
            BitArray_10.Show();
            break;
        case "13":
            Console.WriteLine($"Lab {homework} - BitArrays \n");
            BitArray_10.Show();
            break;
        case "14":
            Console.WriteLine($"Lab {homework} - BitArrays \n");
            BitArray_10.Show();
            break;
        case "15":
            Console.WriteLine($"Lab {homework} - BitArrays \n");
            BitArray_10.Show();
            break;
        case "16":
            Console.WriteLine($"Lab {homework} - BitArrays \n");
            BitArray_10.Show();
            break;
        default:
            Console.WriteLine("No such homework");
            Main();
            break;
    }
}

Main();

public class Stacks_8
{
    public static void Show()
    {
        Console.WriteLine("Create stack of strings, push 9 strings onto stack, pop the first string of stack, look at the peek element and pop it off.\n");
        Stack stack = new Stack();
        for (int i = 0; i <= 9; i++)
        {
            stack.Push($"string{i}");
        }
        Console.WriteLine("Top removed element- " + stack.Pop());
        Console.WriteLine("Top element- " + stack.Peek());
        Console.WriteLine("Top removed element- " + stack.Pop());
    }
}

public class Queues_9
{
    public static void Show()
    {
        Console.WriteLine("Implement radix sort using queue.");
    }
}

public class BitArray_10
{
    public static void Show()
    {
        Console.WriteLine("Create two bit arrays of size 8. Store value 5 into each arrays. Find result of and or operations.");
        byte[] myBytes1 = new byte[8] { 0,0,0,0,0,1,0,1 };
        BitArray myBA1 = new BitArray(myBytes1);
        byte[] myBytes2 = new byte[8] {0, 0, 0, 0, 0, 1, 0, 1 };
        BitArray myBA2 = new BitArray(myBytes2);
     
        BitArray and = myBA1.And(myBA2);
        BitArray or = myBA1.Or(myBA2);
        Console.WriteLine("And:");
        string str1 = "";
        string str2 = "";

        for (int i = 0; i < myBytes1.Length; i++)
        {
           
            
        }
        Console.WriteLine();
        Console.WriteLine("Or:");
        for (int i = 0; i < myBytes2.Length; i++)
        {
            if (or.Get(i))
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}

public class Strings_11
{
    public static void Show()
    {
        Console.WriteLine("Write a function that counts the occurances of letter in text.\n");
        string text = "hello everyone here.";
        Console.WriteLine($"Enter a letter to see its occurance in text '{text}': ");
        string letter = Console.ReadLine();
        int result = 0;
        foreach (char i in text)
        {
            if (i.ToString() == letter)
            {
                result++;
            }
        }
        Console.WriteLine($"'{letter}' occurance: {result}");
    }
}

public class StringBuilder_12
{
    public static void Show()
    {
        Console.WriteLine("1. Write a function that takes a number, and returns it as a word.\n2. Write a function that takes a sentence and pares it into noun-verb-object form");
        int number = 52;

    }

}

public class StringBuilder_13
{
    public static void Show()
    {

    }

}

public class StringBuilder_14
{
    public static void Show()
    {

    }

}

public class StringBuilder_15
{
    public static void Show()
    {

    }

}

public class StringBuilder_16
{
    public static void Show()
    {

    }

}
