namespace ArrayandString;

internal static class SummarySection
{
    public static void WriteSection()
    {
        ConsoleRenderer.WriteSectionTitle("總結");
        ConsoleRenderer.WriteBullet("Array 適合固定長度、同型別資料，重點在索引存取與走訪。");
        ConsoleRenderer.WriteBullet("String 專注於文字處理，重點在不可變性與常見字串方法。");
        ConsoleRenderer.WriteBullet("建議用章節化方式閱讀，再對照 README 與範例原始碼加深理解。");
        ConsoleRenderer.WriteSpacer();
    }
}
