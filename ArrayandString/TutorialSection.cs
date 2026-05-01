namespace ArrayandString;

internal sealed class TutorialSection
{
    private readonly Action _renderAction;

    public TutorialSection(int number, string title, Action renderAction)
    {
        Number = number;
        Title = title;
        _renderAction = renderAction;
    }

    public int Number { get; }

    public string Title { get; }

    public void Render()
    {
        _renderAction();
    }
}
