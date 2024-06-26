﻿class Program
{
    public static string[] EnteringLines()
    {
        int NumberOfLines = 3;
        string[] InputStrings = new string[NumberOfLines];
        for (int i = 0; i < NumberOfLines;)
        {
            Console.WriteLine($"Введите строку №{i + 1}:");
            InputStrings[i] = Console.ReadLine()!;
            Console.WriteLine();
            if (InputStrings[i] == "")
            {
                Console.WriteLine("Не обнаружен ни один символ, пожалуйста, введите хотя бы 1 символ.");
            }
            else
            {
                i++;
            }
        }

        return InputStrings;
    }

    public static string[] ArrayReduction(string[] ArrayStrging)
    {
        int count = 0;
        foreach (string str in ArrayStrging)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        string[] ReducedArray = new string[count];
        int index = 0;
        foreach (string str in ArrayStrging)
        {
            if (str.Length <= 3)
            {
                ReducedArray[index] = str;
                index++;
            }
        }
        return ReducedArray;
    }

    public static void PrintArray(string[] ReducedArray, string[] ArrayStrging)
    {
        Console.WriteLine("Изначальный массив:");
        foreach (var i in ArrayStrging)
        {
            Console.WriteLine($"\"{i}\"");
        }
        Console.WriteLine();
        Console.WriteLine("Строк меньше или равно 3 в массиве:");
        foreach (var j in ReducedArray)
        {
            Console.WriteLine($"\"{j}\"");
        }
    }

    public static void Main()
    {
        string[] ArrayStrging = EnteringLines();
        PrintArray(ArrayReduction(ArrayStrging), ArrayStrging);
    }
}