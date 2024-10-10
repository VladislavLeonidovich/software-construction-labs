class StrategyExample
{
    static void Main(string[] args)
    {
        Image image = new Image(new FileSystemImageLoader());
        image.DisplayImage("image.jpg");

        image = new Image(new NetworkImageLoader());
        image.DisplayImage("http://example.com/image.jpg");
    }
}
