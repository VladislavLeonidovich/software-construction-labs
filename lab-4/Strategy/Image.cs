public class Image
{
    private ImageLoaderStrategy loaderStrategy;

    public Image(ImageLoaderStrategy loaderStrategy)
    {
        this.loaderStrategy = loaderStrategy;
    }

    public void DisplayImage(string source)
    {
        loaderStrategy.LoadImage(source);
    }
}
