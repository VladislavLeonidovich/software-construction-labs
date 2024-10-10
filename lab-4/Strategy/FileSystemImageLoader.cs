public class FileSystemImageLoader : ImageLoaderStrategy
{
    public void LoadImage(string source)
    {
        Console.WriteLine("Завантаження зображення з файлової системи: " + source);
    }
}
