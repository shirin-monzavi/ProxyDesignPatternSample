using System.Drawing;

namespace ProxyDesignPatternSample;

public class Image : IGraphic
{
    #region Field
    private readonly string _fileName;
    private Point _extent;
    #endregion

    public Image(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk();
    }

    public void Draw(Point at)
    {
        Console.WriteLine($"Drawing image {_fileName} at {at.X},{at.Y}");
    }

    public Point GetExtent()
    {
        return _extent;
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Loading image from file {_fileName}...");
        // Simulate loading and image size
        _extent = new Point(100, 100);
    }
}
