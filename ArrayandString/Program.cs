using System.Text;

namespace ArrayandString;

internal static class Program
{
    private static readonly TutorialSection[] Sections =
    {
        new TutorialSection(1, "Array 基本概念與 C# 範例", ArrayExamples.WriteSection),
        new TutorialSection(2, "String 基本概念與 C# 範例", StringExamples.WriteSection),
        new TutorialSection(3, "Array 與 String 的共同點與差異", ComparisonExamples.WriteSection),
        new TutorialSection(4, "常見錯誤與注意事項", CommonPitfalls.WriteSection),
        new TutorialSection(5, "LeetCode 練習建議", PracticeSuggestions.WriteSection),
        new TutorialSection(6, "總結", SummarySection.WriteSection)
    };

    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Run();
    }

    internal static void Run(TextReader? input = null, TextWriter? output = null)
    {
        TextReader originalInput = Console.In;
        TextWriter originalOutput = Console.Out;

        try
        {
            if (input is not null)
            {
                Console.SetIn(input);
            }

            if (output is not null)
            {
                Console.SetOut(output);
            }

            TutorialApplication tutorialApplication = new TutorialApplication(Sections);
            tutorialApplication.Run();
        }
        finally
        {
            if (input is not null)
            {
                Console.SetIn(originalInput);
            }

            if (output is not null)
            {
                Console.SetOut(originalOutput);
            }
        }
    }
}
