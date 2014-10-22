/* 
 * 3. Write a static class with a static method to calculate
 *    the distance between two points in the 3D space.
 */

namespace EuclideanSpace
{
    using System;

    static class PointDistance
    {
        static double DistanceCalc (Point3D point1, Point3D point2) 
        {
            double distanceBetween3DPoints = 
                Math.Sqrt(Math.Pow(point1.X - point2.X, 2) 
                        + Math.Pow(point1.Y - point2.Y, 2) 
                        + Math.Pow(point1.Z - point2.Z, 2) );

            return distanceBetween3DPoints;
        }
    }
}
