# 🎯 Proxy Pattern with C#

This project demonstrates the **Proxy Design Pattern** using a simple document editor example. The goal is to boot perforamnce. Since, expensive objects such as images will be created on demand.

## 🧠 What is the Proxy Pattern?

The **Proxy** pattern provides a placeholder for another object to control access to it.  
A **Virtual Proxy** is used when creating an object is expensive, and we want to delay its creation until it is absolutely needed.
  
## How It Works

1. A `DocumentEditor` object is created.
2. An `ImageProxy` is created with just the image file name — **no actual image is loaded yet**.
3. The `DocumentEditor` can list or manipulate the graphic objects without triggering a load.
4. When the proxy is asked to `Draw()` or `GetExtent()`, **it creates the real `Image` object only at that time**.
5. This saves memory and improves startup time if some images are never used

### 🛠️ Technologies Used
 
C#

.NET Framework 8.0

### 🤝 Contributing
 
Feel free to fork the repository, submit pull requests, or open issues for improvements and discussions.
