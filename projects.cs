using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

void Main()
{
    Console.WriteLine("Choose the homework: ");
    string homework = Console.ReadLine();
    switch (homework)
    {
        case "8":
            Console.WriteLine($"Lab {homework} - Stacks \n");
            Console.WriteLine("Create stack of strings, push 9 strings onto stack, pop the first string of stack, look at the peek element and pop it off.\n");
            Stacks_8.Show();
            break;
        case "9":
            Console.WriteLine($"Lab {homework} - Queues \n");
            Console.WriteLine("Implement radix sort using queue.\n");
            Queues_9.Show();
            break;
        case "10":
            Console.WriteLine($"Lab {homework} - BitArrays \n");
            Console.WriteLine("Create two bit arrays. Store value 5 into each. Find result of AND, OR operations.\n");
            BitArray_10.Show();
            break;
        case "11":
            Console.WriteLine($"Lab {homework} - Strings \n");
            Console.WriteLine("Write a function that counts the occurances of letter in text.\n");
            Strings_11.Show();

            break;
        case "12":
            Console.WriteLine($"Lab {homework} - StringBuilder \n");
            Console.WriteLine("1. Write a function that takes a number, and returns it as a word.\n2. Write a function that takes a sentence and pares it into noun-verb-object form\n");
            StringBuilder_12.Show();
            break;
        case "13":
            Console.WriteLine($"Lab {homework} - Hashing and hashTable \n");
            Console.WriteLine("Using HashTable class, write a spelling checker program that reads through a text and checks for spelling errors. Limit your dictionary to several common words\n");
            Hashing_and_HashTable_13.Show();
            break;
        case "14":
            Console.WriteLine($"Lab {homework} - LinkedList \n");
            LinkedLists_14.Show();
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
        int[] array = { 170, 45, 75, 90, 802, 24, 2, 66 };

        Console.WriteLine("Original Array: " + string.Join(" ", array));
        Console.WriteLine();

        RadixSortAlgorithm(array);

        Console.WriteLine("Sorted Array: " + string.Join(" ", array));
    }

    static void RadixSortAlgorithm(int[] array)
    {
        int max = array.Max();
        for (int exp = 1; max / exp > 0; exp *= 10)
            CountingSort(array, exp);
    }

    static void CountingSort(int[] array, int exp)
    {
        Queue<int>[] buckets = new Queue<int>[10];

        for (int i = 0; i < 10; i++)
            buckets[i] = new Queue<int>();

        foreach (var num in array)
            buckets[(num / exp) % 10].Enqueue(num);

        int index = 0;
        foreach (var bucket in buckets)
            while (bucket.Count > 0)
                array[index++] = bucket.Dequeue();
    }
}

public class BitArray_10
{
    public static void Show()
    {
        // Create two bit arrays of length 8
        BitArray bitArray1 = new BitArray(8);
        BitArray bitArray2 = new BitArray(8);

        // Store the value 5 in each bit array
        SetBitArrayValue(bitArray1, 5);
        SetBitArrayValue(bitArray2, 5);

        // Perform AND operation
        BitArray andResult = BitArrayAnd(bitArray1, bitArray2);

        // Perform OR operation
        BitArray orResult = BitArrayOr(bitArray1, bitArray2);

        // Print results in reverse order
        Console.WriteLine("Bit Array 1: " + Reverse(BitArrayToString(bitArray1)));
        Console.WriteLine("Bit Array 2: " + Reverse(BitArrayToString(bitArray2)));
        Console.WriteLine("AND Result: " + Reverse(BitArrayToString(andResult)));
        Console.WriteLine("OR Result: " + Reverse(BitArrayToString(orResult)));
    }

    static void SetBitArrayValue(BitArray bitArray, int value)
    {
        for (int i = 0; i < bitArray.Length; i++)
        {
            bitArray[i] = (value & (1 << i)) != 0;
        }
    }

    static BitArray BitArrayAnd(BitArray a, BitArray b)
    {
        BitArray result = new BitArray(a);
        result.And(b);
        return result;
    }

    static BitArray BitArrayOr(BitArray a, BitArray b)
    {
        BitArray result = new BitArray(a);
        result.Or(b);
        return result;
    }

    static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string BitArrayToString(BitArray bitArray)
    {
        char[] bits = new char[bitArray.Length];
        for (int i = 0; i < bitArray.Length; i++)
        {
            bits[i] = bitArray[i] ? '1' : '0';
        }
        return new string(bits);
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
        Console.Write("1.Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"Word representation: {NumberToWord(number)}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.Write("2.Enter a sentence: ");
        string sentence = Console.ReadLine();

        var parts = ParseSentence(sentence);

        if (parts.Length == 3)
        {
            Console.WriteLine($"Noun: {parts[0]}, Verb: {parts[1]}, Object: {parts[2]}");
        }
        else
        {
            Console.WriteLine("Invalid sentence format.");
        }
    }

    static string[] ParseSentence(string sentence) =>
        sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Take(3)
                .ToArray();

    static string NumberToWord(int n)
    {
        if (n < 0 || n > 99)
        {
            return "Out of range";
        }

        if (n == 0)
        {
            return "Zero";
        }

        if (n <= 10)
        {
            return SmallNumberToWord(n);
        }

        int tens = n / 10;
        int ones = n % 10;

        return $"{TensPlace(tens)}-{SmallNumberToWord(ones)}";
    }

    static string SmallNumberToWord(int n) => n switch
    {
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        6 => "Six",
        7 => "Seven",
        8 => "Eight",
        9 => "Nine",
        10 => "Ten",
        _ => "Out of range"
    };

    static string TensPlace(int n) => n switch
    {
        2 => "Twenty",
        3 => "Thirty",
        4 => "Forty",
        5 => "Fifty",
        6 => "Sixty",
        7 => "Seventy",
        8 => "Eighty",
        9 => "Ninety",
        _ => "Out of range"
    };

}

public class Hashing_and_HashTable_13
{
    public static void Show()
    {
        Hashtable dictionary = new Hashtable
        {
            { "apple", null },
            { "banana", null },
            { "program", null },
            { "programming", null },
            { "hello", null }
        };

        Console.Write("Enter text to check for spelling errors: ");
        string inputText = Console.ReadLine().ToLower();

        string[] words = inputText.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\nSpelling Errors:");

        foreach (var word in words)
        {
            if (!dictionary.ContainsKey(word))
            {
                Console.WriteLine($"- {word}");
            }
        }


    }

}

public class LinkedLists_14
{
    public static void Show()
    {
        LinkedList<int> list1 = new LinkedList<int>(new[] { 1, 2, 3 });
        LinkedList<int> list2 = new LinkedList<int>(new[] { 4, 5, 6 });

        Console.WriteLine("List 1: " + string.Join(" ", list1));
        Console.WriteLine("List 2: " + string.Join(" ", list2));

        LinkedList<int> circularList = new LinkedList<int>(list1);
        circularList.Last.Value = circularList.First.Value;

        Console.WriteLine("Circular List: " + string.Join(" ", circularList));
        Console.WriteLine("Empty List: " + string.Join(" ", new LinkedList<int>()));
    }

}

