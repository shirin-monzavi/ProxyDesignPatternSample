using ProxyDesignPatternSample;
using System.Drawing;

IGraphic imageProxy = new ImageProxy("big_photo.jpg");

Console.WriteLine("Proxy created, real image NOT loaded yet.");

imageProxy.Draw(new Point(10, 10));

imageProxy.Draw(new Point(20, 20));