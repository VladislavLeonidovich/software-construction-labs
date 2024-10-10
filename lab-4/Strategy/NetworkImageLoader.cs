public class NetworkImageLoader : ImageLoaderStrategy
{
    public void LoadImage(string source)
    {
        Console.WriteLine("Завантаження зображення з мережі: " + source);
    }
}
