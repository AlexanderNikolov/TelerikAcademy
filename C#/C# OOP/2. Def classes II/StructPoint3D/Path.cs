/*
 * 4. Create a class Path to hold a sequence of points in the 3D space.
 *    Create a static class PathStorage with static methods to save
 *    and load paths from a text file. Use a file format of your choice. 
 */

namespace EuclideanSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Path
    {
        private readonly List<Point3D> points = new List<Point3D>();

        //constr
        public Path(Point3D[] point)
        {
            this.Add(points);
        }

        //prop section
        public int Count
        {
            get
            {
                return this.points.Count();
            }
        }

        //methods section
        private void Add(List<Point3D> points)
        {
            throw new NotImplementedException();
        }

    }
}
