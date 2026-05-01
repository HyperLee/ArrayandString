namespace ArrayandString;

internal static class ConsoleRenderer
{
    private const int LineWidth = 88;

    public static void WriteDocumentHeader(string title, string description)
    {
        Console.WriteLine(new string('=', LineWidth));
        Console.WriteLine(title);
        Console.WriteLine(description);
        Console.WriteLine(new string('=', LineWidth));
        Console.WriteLine();
    }

    public static void WriteSectionTitle(string title)
    {
        Console.WriteLine(new string('=', LineWidth));
        Console.WriteLine(title);
        Console.WriteLine(new string('=', LineWidth));
    }

    public static void WriteSubsectionTitle(string title)
    {
        Console.WriteLine();
        Console.WriteLine($"[{title}]");
    }

    public static void WriteBullet(string text)
    {
        Console.WriteLine($"- {text}");
    }

    public static void WriteMenuOption(string key, string title)
    {
        Console.WriteLine($"{key,2}. {title}");
    }

    public static void WriteCode(string code)
    {
        Console.WriteLine($"  {code}");
    }

    public static void WriteResult(string label, object? value)
    {
        Console.WriteLine($"  {label,-24}: {value}");
    }

    public static void WriteNote(string text)
    {
        Console.WriteLine($"  說明: {text}");
    }

    public static void WriteMessage(string text)
    {
        Console.WriteLine(text);
    }

    public static void WritePrompt(string text)
    {
        Console.Write(text);
    }

    public static void WriteSpacer()
    {
        Console.WriteLine();
    }
}
