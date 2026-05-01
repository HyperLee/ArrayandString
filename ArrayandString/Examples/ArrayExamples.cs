namespace ArrayandString;

internal static class ArrayExamples
{
    public static void WriteSection()
    {
        ConsoleRenderer.WriteSectionTitle("Array 基本概念與 C# 範例");
        WriteConceptOverview();
        WriteDeclarationAndUpdateExample();
        WriteTraversalAndLengthExample();
        WriteMultiDimensionalExample();
        WriteCommonOperationsExample();
        WritePracticalScenario();
        ConsoleRenderer.WriteSpacer();
    }

    private static void WriteConceptOverview()
    {
        ConsoleRenderer.WriteSubsectionTitle("核心觀念");
        ConsoleRenderer.WriteBullet("Array 會把同型別資料放在固定長度的連續位置中。");
        ConsoleRenderer.WriteBullet("可以用索引直接讀取或修改指定位置的資料。");
        ConsoleRenderer.WriteBullet("建立後長度固定，若資料量改變，通常要建立新的陣列。");
    }

    private static void WriteDeclarationAndUpdateExample()
    {
        // 這個範例展示最基礎的宣告、讀取與修改流程。
        int[] scores = { 95, 88, 76, 100 };

        ConsoleRenderer.WriteSubsectionTitle("宣告、初始化與索引讀寫");
        ConsoleRenderer.WriteCode("int[] scores = { 95, 88, 76, 100 };");
        ConsoleRenderer.WriteResult("scores[1]", scores[1]);

        scores[2] = 80;
        ConsoleRenderer.WriteCode("scores[2] = 80;");
        ConsoleRenderer.WriteResult("修改後內容", string.Join(", ", scores));
    }

    private static void WriteTraversalAndLengthExample()
    {
        int[] scores = { 95, 88, 80, 100 };

        ConsoleRenderer.WriteSubsectionTitle("走訪與長度");
        ConsoleRenderer.WriteCode("for (int index = 0; index < scores.Length; index++) { ... }");

        for (int index = 0; index < scores.Length; index++)
        {
            ConsoleRenderer.WriteResult($"scores[{index}]", scores[index]);
        }

        ConsoleRenderer.WriteResult("scores.Length", scores.Length);
        ConsoleRenderer.WriteNote("Array 適合需要依序走訪，或要快速取得固定位置資料的情境。");
    }

    private static void WriteMultiDimensionalExample()
    {
        // 二維陣列適合表示表格、座位或棋盤等資料。
        int[,] seats = { { 1, 0, 1 }, { 0, 1, 1 } };

        ConsoleRenderer.WriteSubsectionTitle("二維陣列");
        ConsoleRenderer.WriteCode("int[,] seats = { { 1, 0, 1 }, { 0, 1, 1 } };");
        ConsoleRenderer.WriteResult("seats[1, 2]", seats[1, 2]);
        ConsoleRenderer.WriteNote("二維陣列可用 row, column 的方式描述表格狀資料。");
    }

    private static void WriteCommonOperationsExample()
    {
        int[] originalNumbers = { 4, 2, 7, 1 };
        int[] copiedNumbers = new int[originalNumbers.Length];

        ConsoleRenderer.WriteSubsectionTitle("常見方法與實用操作");
        ConsoleRenderer.WriteCode("Array.Copy(originalNumbers, copiedNumbers, originalNumbers.Length);");
        Array.Copy(originalNumbers, copiedNumbers, originalNumbers.Length);

        ConsoleRenderer.WriteCode("Array.Sort(copiedNumbers);");
        Array.Sort(copiedNumbers);
        ConsoleRenderer.WriteResult("排序後", string.Join(", ", copiedNumbers));
        ConsoleRenderer.WriteResult("Array.IndexOf(..., 7)", Array.IndexOf(originalNumbers, 7));

        ConsoleRenderer.WriteCode("Array.Reverse(copiedNumbers);");
        Array.Reverse(copiedNumbers);
        ConsoleRenderer.WriteResult("反轉後", string.Join(", ", copiedNumbers));
    }

    private static void WritePracticalScenario()
    {
        int[] weeklySales = { 18, 21, 16, 24, 20 };
        int total = 0;

        // 用累加與平均，展示 Array 在固定筆數資料中的實務用途。
        for (int index = 0; index < weeklySales.Length; index++)
        {
            total += weeklySales[index];
        }

        double average = (double)total / weeklySales.Length;

        ConsoleRenderer.WriteSubsectionTitle("實務情境：一週銷售統計");
        ConsoleRenderer.WriteResult("每日銷售", string.Join(", ", weeklySales));
        ConsoleRenderer.WriteResult("總銷售", total);
        ConsoleRenderer.WriteResult("平均銷售", average.ToString("0.0"));
        ConsoleRenderer.WriteNote("已知資料筆數且需要依索引統計時，Array 是很直接的選擇。");
    }
}
