public class RasterRenderer : IRenderer
{
    public void Render(string shape) 
    {
        Console.WriteLine($"Drawing {shape} as pixels.");
    }
}

public class VectorRenderer : IRenderer
{
    public void Render(string shape) 
    {
        Console.WriteLine($"Drawing {shape} as vectors.");
    }
}
