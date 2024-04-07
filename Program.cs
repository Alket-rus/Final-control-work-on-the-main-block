class Program
{
    public static string[] EnteringLines()
    {
        int i = 0;
        string[] inputStrings = new string[0];
        while (true)
        {
            Console.WriteLine($"Введите строку №{i + 1} или нажмите Q чтобы закончить:");
            string input = Console.ReadLine()!;
            Console.WriteLine();
            if (input == "")
            {
                Console.WriteLine("Не обнаружен ни один символ, пожалуйста, введите хотя бы 1 символ.");
            }
            if (input == "Q" && input == "q")
            {
                return inputStrings;
            }
            else
            {
                Array.Resize(ref inputStrings, inputStrings.Length + 1);
                inputStrings[inputStrings.Length - 1] = input;
                i++;
            }
        }
    }

    public static string[] ArrayReduction(string[] ArrayStrging)
    {
        if (ArrayStrging == null || ArrayStrging.Length == 0)
        {
            return new string[0];
        }

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