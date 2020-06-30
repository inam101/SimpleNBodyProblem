using AForge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallGames
{
    public static class ExtensionsForPoint
    {
        public static DoublePoint Substract(this DoublePoint thePoint, DoublePoint point)
        {
            return new DoublePoint(thePoint.X - point.X, thePoint.Y - point.Y);
        }

        public static DoublePoint Add(this DoublePoint thePoint, DoublePoint point)
        {
            return new DoublePoint(thePoint.X + point.X, thePoint.Y + point.Y);
        }

        public static double Magnitude(this DoublePoint thePoint)
        {
            return Math.Sqrt((thePoint.X * thePoint.X) + (thePoint.Y * thePoint.Y));
        }

        public static DoublePoint Multiply(this DoublePoint thePoint, double multiple)
        {
            return new DoublePoint(thePoint.X * multiple, thePoint.Y * multiple);
        }

        public static DoublePoint Normalize(this DoublePoint thePoint)
        {
            var magnitude = (double)thePoint.Magnitude();
            return new DoublePoint(thePoint.X / magnitude, thePoint.Y / magnitude);
        }


        public static DoublePoint Reverse(this DoublePoint thePoint)
        {
            return new DoublePoint(-thePoint.X, -thePoint.Y);
        }

        public static double DistanceBetween(this DoublePoint thePoint, DoublePoint point)
        {
            var diff = thePoint.Substract(point);
            return diff.Magnitude();
        }

        /// <summary>
        /// Unit vector from the current point to the target point 
        /// </summary>
        /// <param name="thePoint">current point</param>
        /// <param name="point">tatrget point</param>
        /// <returns>Unit vector or direction vector</returns>
        public static DoublePoint DirectionVector(this DoublePoint thePoint, DoublePoint point)
        {
            var diff = thePoint.Substract(point);
            return diff.Normalize();
        }

        public static DoublePoint Sum(this IEnumerable<DoublePoint> points)
        {
            var total = new DoublePoint(0, 0);
            foreach (var item in points)
            {
                total = item.Add(total);
            }
            return total;
        }
    }
}
