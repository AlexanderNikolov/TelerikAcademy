namespace ShapeSpace
{
    using System;

    class Rectangle : Shape
    {
        public Rectangle(int width, int height)
            : base(width, height)
        {
        }

        public override void CalculateSurface()
        {
            Console.WriteLine(Width * Height);
        }
    }
}
