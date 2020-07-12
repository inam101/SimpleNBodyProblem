using AForge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallGames
{
    public class Distribution
    {
        public string Name { get; }
        public string Code { get; }

        public static string DefaultName { get { return "Equal"; } }

        public Distribution()
        {
            Name = DefaultName;
            Code = DefaultName;
        }

        public Distribution(string name)
        {
            Name = name;
            Code = name.Replace(" ", "");
        }


        public List<long> GetDistributionMassValues(long count, long unitValue, long distinctValues)
        {
            List<long> values = new List<long>();
            if (Code == "Equal")
            {
                for (long i = 0; i < count; i++)
                {
                    var d = 1 + (Tools.GetRandomNo(10) % distinctValues);
                    values.Add(unitValue * d);
                }
            }
            else
            {
                for (long i = 0; i < count; i++)
                {
                    values.Add(unitValue);
                }
            }
            return values;
        }

        public List<DoublePoint> GetPositionDistributionValues(long count, long size)
        {
            List<DoublePoint> values = new List<DoublePoint>();
            List<PointF> clusters = new List<PointF>();
            float clusteringGridSize = 5;
            if (Code == "Clustered")
            {
                for (int i = 0; i < 10; i++)
                {
                    var pt = new PointF(Tools.GetRandomNo(10) % 6, Tools.GetRandomNo(10) % 6);
                    if (clusters.Contains(pt)) i--;
                    else clusters.Add(pt);
                }
            }
            else if (Code == "Spiral")
            {
                var sprialCode = Tools.GetRandomNo(10) % 2;
                if (sprialCode == 0)
                {
                    clusters = new List<PointF> { new PointF(2.5F,2.5F), new PointF(3, 3), new PointF(2, 4),
                    new PointF(0,3), new PointF(1,1), new PointF(4,0), new PointF(5,3), new PointF(4,5)};
                }
                else if (sprialCode == 1)
                {
                    clusters = new List<PointF> { new PointF(2.5F,2.5F), new PointF(2,2), new PointF(2, 3),
                    new PointF(3,3), new PointF(3,2), new PointF(1,2), new PointF(3,1), new PointF(4,3),
                    new PointF(2,4), new PointF(0,0), new PointF(0,5), new PointF(5,5), new PointF(5,0)};
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    var x = (double)Tools.GetRandomNo(30) % size;
                    var y = (double)Tools.GetRandomNo(30) % size;
                    values.Add(new DoublePoint(x, y));
                }
            }
            var factorForSize =  (double)size / clusteringGridSize;
            var aClusters = clusters.ToArray();
            if (aClusters.Length > 0 && values.Count == 0)
            {
                for (int i = 0; i < count; i++)
                {
                    var index = Tools.GetRandomNo(10) % aClusters.Length;
                    var x = (4.0 - ((double)Tools.GetRandomNo(10) % 9))/10;
                    var y = (4.0 - ((double)Tools.GetRandomNo(10) % 9))/10;
                    values.Add(new DoublePoint((aClusters[index].X + x) * factorForSize, (aClusters[index].Y + y) * factorForSize));
                }
            }
            return values;
        }

        public static List<Distribution> SomeDistributions()
        {
            List<Distribution> distributions = new List<Distribution>
            {
                new Distribution("None"),
                new Distribution("Equal"),
                new Distribution("Clustered"),
                new Distribution("Spiral")
            };

            return distributions;
        }

    }
}
