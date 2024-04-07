class Program
{
    public static string[] EnteringLines()
    {
        int NumberOfLines = 3;
        string[] Strging = new string[NumberOfLines];
        for (int i = 0; i < NumberOfLines;)
        {
            Console.WriteLine($"Введите строку №{i + 1}:");
            Strging[i] = Console.ReadLine()!;
            Console.WriteLine();
        }

        return Strging;
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
}