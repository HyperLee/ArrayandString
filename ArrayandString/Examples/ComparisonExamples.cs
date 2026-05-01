namespace ArrayandString;

internal static class ComparisonExamples
{
    public static void WriteSection()
    {
        ConsoleRenderer.WriteSectionTitle("Array 與 String 的共同點與差異");
        WriteSharedCharacteristics();
        WriteMutabilityComparison();
        WriteTypeAndMemoryComparison();
        WriteUsageComparison();
        ConsoleRenderer.WriteSpacer();
    }

    private static void WriteSharedCharacteristics()
    {
        ConsoleRenderer.WriteSubsectionTitle("共同點");
        ConsoleRenderer.WriteBullet("兩者都可以用索引讀取指定位置的內容。");
        ConsoleRenderer.WriteBullet("兩者都能搭配迴圈走訪內容。");
        ConsoleRenderer.WriteBullet("兩者都很常出現在基礎演算法與資料處理題目中。");
    }

    private static void WriteMutabilityComparison()
    {
        char[] letters = { 'c', 'o', 'd', 'e' };
        string word = "code";

        // 陣列可以原地修改；字串需要回傳新值。
        letters[0] = 'n';
        string changedWord = word.Replace('c', 'n');

        ConsoleRenderer.WriteSubsectionTitle("可變與不可變");
        ConsoleRenderer.WriteResult("Array 修改後", new string(letters));
        ConsoleRenderer.WriteResult("String 原值", word);
        ConsoleRenderer.WriteResult("String 新值", changedWord);
        ConsoleRenderer.WriteNote("Array 可直接改元素；String 的修改方法會回傳新字串。");
    }

    private static void WriteTypeAndMemoryComparison()
    {
        ConsoleRenderer.WriteSubsectionTitle("元素型別與記憶體觀念");
        ConsoleRenderer.WriteBullet("Array 可以儲存任何同型別資料，例如 int、double、char。");
        ConsoleRenderer.WriteBullet("String 專門表示文字，本質上是一串 char。");
        ConsoleRenderer.WriteBullet("Array 建立時會配置固定數量的元素位置；String 因不可變而在修改時建立新結果。");
        ConsoleRenderer.WriteBullet("若文字需要頻繁拼接，可進一步學習 StringBuilder。");
    }

    private static void WriteUsageComparison()
    {
        ConsoleRenderer.WriteSubsectionTitle("典型使用時機");
        ConsoleRenderer.WriteResult("Array", "成績、座標、每日銷售、固定筆數資料");
        ConsoleRenderer.WriteResult("String", "姓名、句子、關鍵字、文字清理與格式處理");
        ConsoleRenderer.WriteResult("共同學習價值", "雙指針、滑動視窗、索引操作、走訪技巧");
    }
}
