namespace ProxyDesignPatternSample;

public class DocumentEditor
{
    #region Field
    private readonly List<IGraphic> _graphics;
    #endregion

    public DocumentEditor()
    {
        _graphics = new List<IGraphic>();
    }

    public void Add(IGraphic graphic)
    {
        _graphics.Add(graphic);
    }

    public void DrawAll()
    {
        Console.WriteLine("Document drawing all graphics...");

        foreach (IGraphic graphic in _graphics)
        {
            graphic.Draw(new System.Drawing.Point(10, 10));
        }
    }
}
