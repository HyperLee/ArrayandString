namespace ArrayandString;

internal static class PracticeSuggestions
{
    private static readonly PracticeItem[] PracticeItems =
    {
        new PracticeItem(1, "Two Sum", "Array / Hashing", "Easy", "索引查找、配對思維"),
        new PracticeItem(2, "Remove Duplicates from Sorted Array", "Array / Two Pointers", "Easy", "原地修改、雙指針"),
        new PracticeItem(3, "Valid Palindrome", "String / Two Pointers", "Easy", "字元判斷、左右夾逼"),
        new PracticeItem(4, "Longest Common Prefix", "String", "Easy", "逐字比較、邊界處理"),
        new PracticeItem(5, "Best Time to Buy and Sell Stock", "Array", "Easy", "一次走訪、最佳值更新"),
        new PracticeItem(6, "Longest Substring Without Repeating Characters", "String / Sliding Window", "Medium", "滑動視窗、集合判斷"),
        new PracticeItem(7, "Group Anagrams", "String / Hashing", "Medium", "分類、字串特徵轉換"),
        new PracticeItem(8, "Product of Array Except Self", "Array / Prefix", "Medium", "前後綴乘積、空間思維"),
        new PracticeItem(9, "Minimum Window Substring", "String / Sliding Window", "Hard", "進階視窗控制、計數維護")
    };

    public static void WriteSection()
    {
        ConsoleRenderer.WriteSectionTitle("LeetCode 練習建議");
        ConsoleRenderer.WriteBullet("建議先從索引、走訪與雙指針題型開始，再進入滑動視窗與雜湊分類。");
        ConsoleRenderer.WriteBullet("練習時不要只背答案，要回頭連結到 Array 與 String 的資料特性。");

        foreach (PracticeItem practiceItem in PracticeItems)
        {
            ConsoleRenderer.WriteSubsectionTitle($"順序 {practiceItem.RecommendedOrder}: {practiceItem.Title}");
            ConsoleRenderer.WriteResult("類型", practiceItem.Category);
            ConsoleRenderer.WriteResult("難度", practiceItem.Difficulty);
            ConsoleRenderer.WriteResult("練習重點", practiceItem.Focus);
        }

        ConsoleRenderer.WriteSubsectionTitle("建議練習順序");
        ConsoleRenderer.WriteBullet("先完成 Easy 題，建立索引、長度、走訪與字元處理的穩定度。");
        ConsoleRenderer.WriteBullet("接著進入 Medium 題，熟悉雙指針、滑動視窗與前後綴技巧。");
        ConsoleRenderer.WriteBullet("最後挑戰進階題，練習更嚴謹的條件維護與邊界處理。");
        ConsoleRenderer.WriteSpacer();
    }

    private sealed record PracticeItem(
        int RecommendedOrder,
        string Title,
        string Category,
        string Difficulty,
        string Focus);
}
