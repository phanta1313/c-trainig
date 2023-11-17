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
            Console.WriteLine($"Lab {homework} - BitArrays \n");
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
        Stack stack = new Stack();
        for (int i = 0; i<=9; i++)
        {
            stack.Push($"string{i}");
        }
        Console.WriteLine("Top removed element- "+stack.Pop());
        Console.WriteLine("Top element- " + stack.Peek());
        Console.WriteLine("Top removed element- " + stack.Pop());
    }
}

public class Queues_9
{
    public static void Show()
    {

    }
}

public class BitArray_10
{
    public static void Show()
    {
        BitArray myBA1 = new BitArray(8, true);
        for (int i = 0; i > myBA1.Count; i++)
        {
            myBA1.Set(5, false);
        };
        BitArray myBA2 = new BitArray(8, false);
        for (int i = 0; i > myBA2.Count; i++)
        {
            myBA2.Set(5, false);
        };

        BitArray and = myBA1.And(myBA2);
        BitArray or = myBA1.Or(myBA2);
        Console.WriteLine("And:");

        for (int i = 0; i < myBA1.Count; i++)
        {
            Console.WriteLine(and.Get(i));
        }
        Console.WriteLine("Or:");
        for (int i = 0; i < myBA1.Count; i++)
        {
            Console.WriteLine(or.Get(i));
        }
    }
}

public class Strings_11
{
    public static void Show()
    {
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
