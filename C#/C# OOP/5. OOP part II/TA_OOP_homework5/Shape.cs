namespace ShapeSpace
{
    using System;

    abstract class Shape
    {
        private int width;
        private int height;

        //.tor
        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid argument");
                this.width = value;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid argument");
                this.height = value;
            }
        }

        //virtual method
        public virtual void CalculateSurface()
        {
        }
    }
}
