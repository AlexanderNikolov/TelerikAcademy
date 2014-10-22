namespace ShapeSpace
{
    using System;

    class Triangle : Shape
    {
        public Triangle(int width, int height)
            : base(width, height)
        {
        }

        public override void CalculateSurface()
        {
            Console.WriteLine( (Width * Height) / 2); 
        }
    }
}
