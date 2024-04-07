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
}