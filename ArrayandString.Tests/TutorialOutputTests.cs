using ArrayandString;

namespace ArrayandString.Tests;

public class TutorialOutputTests
{
    [Fact]
    public void ArrayExamplesWriteSection_PrintsCoreTopics()
    {
        string output = CaptureOutput(ArrayExamples.WriteSection);

        Assert.Contains("Array 基本概念與 C# 範例", output);
        Assert.Contains("scores.Length", output);
        Assert.Contains("一週銷售統計", output);
    }

    [Fact]
    public void StringExamplesWriteSection_PrintsImmutabilityLesson()
    {
        string output = CaptureOutput(StringExamples.WriteSection);

        Assert.Contains("String 基本概念與 C# 範例", output);
        Assert.Contains("不可變性示範", output);
        Assert.Contains("DOTNET", output);
    }

    [Fact]
    public void ComparisonExamplesWriteSection_PrintsMutabilityComparison()
    {
        string output = CaptureOutput(ComparisonExamples.WriteSection);

        Assert.Contains("Array 與 String 的共同點與差異", output);
        Assert.Contains("Array 修改後", output);
        Assert.Contains("String 新值", output);
    }

    [Fact]
    public void CommonPitfallsWriteSection_PrintsTypicalMistakes()
    {
        string output = CaptureOutput(CommonPitfalls.WriteSection);

        Assert.Contains("IndexOutOfRangeException", output);
        Assert.Contains("未重新指派", output);
        Assert.Contains("Array 會自動擴充", output);
    }

    [Fact]
    public void PracticeSuggestionsWriteSection_PrintsLearningPath()
    {
        string output = CaptureOutput(PracticeSuggestions.WriteSection);

        Assert.Contains("Two Sum", output);
        Assert.Contains("Minimum Window Substring", output);
        Assert.Contains("建議練習順序", output);
    }

    private static string CaptureOutput(Action action)
    {
        StringWriter writer = new StringWriter();
        TextWriter originalWriter = Console.Out;

        try
        {
            Console.SetOut(writer);
            action();
            return writer.ToString();
        }
        finally
        {
            Console.SetOut(originalWriter);
        }
    }
}
