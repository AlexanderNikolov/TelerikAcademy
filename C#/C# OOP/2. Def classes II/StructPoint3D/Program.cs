/* 1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z}
 *    in the Euclidian 3D space. Implement the ToString() to enable
 *    printing a 3D point.
 * 2. Add a private static read-only field to hold the start of
 *    the coordinate system – the point O{0, 0, 0}. Add a static
 *    property to return the point O.
 * 3. Write a static class with a static method to calculate
 *    the distance between two points in the 3D space.
 * 4. Create a class Path to hold a sequence of points in the 3D space.
 *    Create a static class PathStorage with static methods to save
 *    and load paths from a text file. Use a file format of your choice. 
 */

using System;
using EuclideanSpace;

public class Program
{
    static void Main()
    {
        //instance A
        Point3D point = new Point3D();
        point.X = 1;
        point.Y = 1;
        point.Z = 1;

        //instance B
        Point3D pointB = new Point3D() { X = 1, Y = -1, Z = 1 };

        //instance C
        Point3D pointC = new Point3D(-1, -1, -1);

        //output
        Console.WriteLine("new instance A: {0}\n", point);
        Console.WriteLine("new instance B: {0}\n", pointB);
        Console.WriteLine("new instance C: {0}\n", pointC);
        Console.WriteLine("center: {0}\n", Point3D.Center);
    }
}
