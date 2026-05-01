namespace ArrayandString;

internal sealed class TutorialApplication
{
    private readonly IReadOnlyList<TutorialSection> _sections;

    public TutorialApplication(IReadOnlyList<TutorialSection> sections)
    {
        _sections = sections;
    }

    public void Run()
    {
        while (true)
        {
            WriteMenu();

            string? rawSelection = Console.ReadLine();
            if (rawSelection is null)
            {
                return;
            }

            if (!int.TryParse(rawSelection, out int selection))
            {
                ConsoleRenderer.WriteMessage("請輸入有效的數字選項。");
                ConsoleRenderer.WriteSpacer();
                continue;
            }

            if (selection == 0)
            {
                ConsoleRenderer.WriteMessage("已結束教學選單。");
                return;
            }

            TutorialSection? selectedSection = FindSection(selection);
            if (selectedSection is null)
            {
                ConsoleRenderer.WriteMessage("查無此章節，請重新輸入。");
                ConsoleRenderer.WriteSpacer();
                continue;
            }

            ConsoleRenderer.WriteSpacer();
            selectedSection.Render();
            ConsoleRenderer.WriteMessage("按 Enter 返回主選單。");
            Console.ReadLine();
            ConsoleRenderer.WriteSpacer();
        }
    }

    private TutorialSection? FindSection(int selection)
    {
        foreach (TutorialSection section in _sections)
        {
            if (section.Number == selection)
            {
                return section;
            }
        }

        return null;
    }

    private void WriteMenu()
    {
        ConsoleRenderer.WriteDocumentHeader(
            "Array / String C# 教學專案",
            "請選擇想閱讀的章節編號，程式只會輸出你目前需要的內容。");

        ConsoleRenderer.WriteSubsectionTitle("使用方式");
        ConsoleRenderer.WriteBullet("輸入數字後只顯示該章節，避免一次讀完所有內容。");
        ConsoleRenderer.WriteBullet("閱讀完畢按 Enter 返回主選單，繼續查看其他主題。");
        ConsoleRenderer.WriteSpacer();

        ConsoleRenderer.WriteSubsectionTitle("章節列表");

        foreach (TutorialSection section in _sections)
        {
            ConsoleRenderer.WriteMenuOption(section.Number.ToString(), section.Title);
        }

        ConsoleRenderer.WriteMenuOption("0", "結束程式");
        ConsoleRenderer.WriteSpacer();
        ConsoleRenderer.WritePrompt("請輸入章節編號: ");
    }
}
