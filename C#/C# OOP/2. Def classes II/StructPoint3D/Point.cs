/* 1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z}
 *    in the Euclidian 3D space. Implement the ToString() to enable
 *    printing a 3D point.
 * 2. Add a private static read-only field to hold the start of
 *    the coordinate system – the point O{0, 0, 0}. Add a static
 *    property to return the point O.
 */

namespace EuclideanSpace
{
    using System;

    public struct Point3D
    {
        //1.
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        //2.
        private static readonly Point3D center = new Point3D(0, 0, 0);

        //constructor
        public Point3D(int x, int y, int z)
            : this() //<- important
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //2...static property to return center
        public static Point3D Center
        {
            get { return center; }
        }

        //override method
        public override string ToString()
        {
            string stringPoint = string.Format("Point({0},{1},{2})", this.X, this.Y, this.Z);
            return stringPoint;
        }

    }
}
