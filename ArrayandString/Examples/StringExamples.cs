namespace ArrayandString;

internal static class StringExamples
{
    public static void WriteSection()
    {
        ConsoleRenderer.WriteSectionTitle("String 基本概念與 C# 範例");
        WriteConceptOverview();
        WriteDeclarationAndLengthExample();
        WriteConcatenationAndSubstringExample();
        WriteCommonOperationsExample();
        WriteImmutabilityExample();
        WritePracticalScenario();
        ConsoleRenderer.WriteSpacer();
    }

    private static void WriteConceptOverview()
    {
        ConsoleRenderer.WriteSubsectionTitle("核心觀念");
        ConsoleRenderer.WriteBullet("String 用來表示文字內容，可視為一串字元序列。");
        ConsoleRenderer.WriteBullet("可以用索引讀取單一字元，但不能直接修改指定位置的字元。");
        ConsoleRenderer.WriteBullet("C# 的 String 是不可變物件，修改行為通常會產生新字串。");
    }

    private static void WriteDeclarationAndLengthExample()
    {
        string title = "Array and String";

        ConsoleRenderer.WriteSubsectionTitle("宣告、索引與長度");
        ConsoleRenderer.WriteCode("string title = \"Array and String\";");
        ConsoleRenderer.WriteResult("title[0]", title[0]);
        ConsoleRenderer.WriteResult("title.Length", title.Length);
        ConsoleRenderer.WriteNote("索引回傳的是 char，而不是 string。");
    }

    private static void WriteConcatenationAndSubstringExample()
    {
        string firstName = "Qiuzili";
        string greeting = "Hello, " + firstName + "!";
        string title = "Array and String";
        string topic = title.Substring(10, 6);

        ConsoleRenderer.WriteSubsectionTitle("串接與部分擷取");
        ConsoleRenderer.WriteCode("string greeting = \"Hello, \" + firstName + \"!\";");
        ConsoleRenderer.WriteResult("串接結果", greeting);
        ConsoleRenderer.WriteCode("string topic = title.Substring(10, 6);");
        ConsoleRenderer.WriteResult("Substring 結果", topic);
    }

    private static void WriteCommonOperationsExample()
    {
        string csvLine = "apple,banana,orange";
        string replacedLine = csvLine.Replace("orange", "grape");
        string[] fruits = csvLine.Split(',');

        ConsoleRenderer.WriteSubsectionTitle("搜尋、取代與分割");
        ConsoleRenderer.WriteResult("Contains(\"banana\")", csvLine.Contains("banana"));
        ConsoleRenderer.WriteResult("Replace 後", replacedLine);
        ConsoleRenderer.WriteResult("Split 後數量", fruits.Length);

        for (int index = 0; index < fruits.Length; index++)
        {
            ConsoleRenderer.WriteResult($"fruits[{index}]", fruits[index]);
        }
    }

    private static void WriteImmutabilityExample()
    {
        // 字串看起來像被改變，實際上是得到新的字串物件。
        string original = "dotnet";
        string upper = original.ToUpperInvariant();

        ConsoleRenderer.WriteSubsectionTitle("不可變性示範");
        ConsoleRenderer.WriteResult("original", original);
        ConsoleRenderer.WriteResult("upper", upper);
        ConsoleRenderer.WriteNote("呼叫 ToUpperInvariant 後，original 仍保留原值，upper 才是新結果。");
    }

    private static void WritePracticalScenario()
    {
        string rawInput = "  alice chen  ";
        string normalizedInput = rawInput.Trim().Replace("  ", " ").ToUpperInvariant();

        ConsoleRenderer.WriteSubsectionTitle("實務情境：整理文字輸入");
        ConsoleRenderer.WriteResult("原始輸入", rawInput);
        ConsoleRenderer.WriteResult("整理後", normalizedInput);
        ConsoleRenderer.WriteNote("處理姓名、標籤、句子或 CSV 時，String 的方法很常用。");
    }
}
