public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }

    public override void Draw() 
    {
        renderer.Render("Circle");
    }
}

public class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer) { }

    public override void Draw() 
    {
        renderer.Render("Square");
    }
}
