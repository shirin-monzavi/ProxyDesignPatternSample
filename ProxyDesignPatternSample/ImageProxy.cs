using System.Drawing;

namespace ProxyDesignPatternSample;

public class ImageProxy : IGraphic
{
    #region Field
    private readonly string _fileName;
    private Image _realImage;
    private Point _extent = Point.Empty;
    #endregion

    public ImageProxy(string fileName)
    {
        _fileName = fileName;
    }

    public void Draw(Point at)
    {
        GetRealImage().Draw(at);
    }

    public Point GetExtent()
    {
        if (_extent == Point.Empty)
        {
            _extent = GetRealImage().GetExtent();
        }
        return _extent;
    }

    private Image GetRealImage()
    {
        if (_realImage is null)
        {
            _realImage = new Image(_fileName);
            _extent = _realImage.GetExtent();
        }
        return _realImage;
    }
}
