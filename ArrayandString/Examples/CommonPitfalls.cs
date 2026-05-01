namespace ArrayandString;

internal static class CommonPitfalls
{
    public static void WriteSection()
    {
        ConsoleRenderer.WriteSectionTitle("常見錯誤與注意事項");
        WriteIndexOutOfRangeExample();
        WriteStringAssignmentExample();
        WriteCharVsStringExample();
        WriteFixedLengthExample();
        ConsoleRenderer.WriteSpacer();
    }

    private static void WriteIndexOutOfRangeExample()
    {
        int[] scores = { 95, 88, 80 };

        ConsoleRenderer.WriteSubsectionTitle("索引超出範圍");

        try
        {
            int invalidValue = scores[5];
            ConsoleRenderer.WriteResult("invalidValue", invalidValue);
        }
        catch (IndexOutOfRangeException exception)
        {
            ConsoleRenderer.WriteResult("例外型別", exception.GetType().Name);
            ConsoleRenderer.WriteNote("Array 與 String 都要先確認索引是否合法，再進行存取。");
        }
    }

    private static void WriteStringAssignmentExample()
    {
        string userName = "alice";

        ConsoleRenderer.WriteSubsectionTitle("忘記重新指派字串結果");
        ConsoleRenderer.WriteCode("userName.Replace(\"a\", \"A\");");
        userName.Replace("a", "A");
        ConsoleRenderer.WriteResult("未重新指派", userName);

        userName = userName.Replace("a", "A");
        ConsoleRenderer.WriteResult("重新指派後", userName);
        ConsoleRenderer.WriteNote("字串方法常會回傳新值，如果不接回來，原字串不會改變。");
    }

    private static void WriteCharVsStringExample()
    {
        char firstLetter = 'A';
        string firstText = "A";

        ConsoleRenderer.WriteSubsectionTitle("混淆 char 與 string");
        ConsoleRenderer.WriteResult("char", firstLetter);
        ConsoleRenderer.WriteResult("string", firstText);
        ConsoleRenderer.WriteNote("char 代表單一字元，string 代表字串；兩者用途不同。");
    }

    private static void WriteFixedLengthExample()
    {
        int[] fixedSizeNumbers = { 1, 2, 3 };
        int[] expandedNumbers = new int[fixedSizeNumbers.Length + 1];

        ConsoleRenderer.WriteSubsectionTitle("誤以為 Array 會自動擴充");
        Array.Copy(fixedSizeNumbers, expandedNumbers, fixedSizeNumbers.Length);
        expandedNumbers[expandedNumbers.Length - 1] = 4;

        ConsoleRenderer.WriteResult("原始內容", string.Join(", ", fixedSizeNumbers));
        ConsoleRenderer.WriteResult("擴充後內容", string.Join(", ", expandedNumbers));
        ConsoleRenderer.WriteNote("Array 長度固定；如果需要動態增減，通常要建立新陣列或改用 List<T>。");
    }
}
