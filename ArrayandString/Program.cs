using System.Text;

namespace ArrayandString;

internal static class Program
{
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        ConsoleRenderer.WriteDocumentHeader(
            "Array / String C# 教學專案",
            "本程式依主題順序輸出完整教學內容，方便對照 README 與範例原始碼一起學習。");

        ConsoleRenderer.WriteSubsectionTitle("學習目標");
        ConsoleRenderer.WriteBullet("理解 Array 與 String 的定義、特性與常見使用時機。");
        ConsoleRenderer.WriteBullet("透過 C# 範例觀察宣告、走訪、修改與常用操作方式。");
        ConsoleRenderer.WriteBullet("掌握常見錯誤，並建立延伸到 LeetCode 練習的學習路徑。");
        ConsoleRenderer.WriteSpacer();

        ArrayExamples.WriteSection();
        StringExamples.WriteSection();
        ComparisonExamples.WriteSection();
        CommonPitfalls.WriteSection();
        PracticeSuggestions.WriteSection();

        ConsoleRenderer.WriteSectionTitle("總結");
        ConsoleRenderer.WriteBullet("Array 適合固定長度、同型別資料，重點在索引存取與走訪。");
        ConsoleRenderer.WriteBullet("String 專注於文字處理，重點在不可變性與常見字串方法。");
        ConsoleRenderer.WriteBullet("當需求是可執行教學時，請一邊閱讀 README，一邊執行本程式觀察輸出。");
    }
}
