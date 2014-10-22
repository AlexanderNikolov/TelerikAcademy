namespace ShapeSpace
{
    using System;

    class Circle : Shape
    {
        public Circle(int width)
            : base(width, width)
        {
        }

        public override void CalculateSurface()
        {
            Console.WriteLine(Math.PI * Width * Width);
        }
    }
}
