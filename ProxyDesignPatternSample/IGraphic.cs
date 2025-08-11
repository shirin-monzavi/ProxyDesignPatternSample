using System.Drawing;

namespace ProxyDesignPatternSample;

public interface IGraphic
{
    void Draw(Point at);
    Point GetExtent();
}
