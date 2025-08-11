using ProxyDesignPatternSample;

DocumentEditor document = new();

// Insert image proxies - real images not loaded yet
document.Add(new ImageProxy("big_photo.jpg"));
document.Add(new ImageProxy("another_photo.png"));

Console.WriteLine("Document created with image proxies (no real images loaded yet).");

document.DrawAll();

document.DrawAll();