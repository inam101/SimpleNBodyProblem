using System;
using System.Collections.Generic;
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


        public List<long> GetDistributionValues(long count, long unitValue, long distinctValues)
        {
            List<long> values = new List<long>();
            if(Code == "Equal")
            {
                for (long i = 0; i < count; i++)
                {
                    var d = 1 + (Tools.GetRandomNo(10) % distinctValues);
                    values.Add(unitValue * d);
                }
            }
            else if (Code == "None")
            {
                for (long i = 0; i < count; i++)
                {
                    values.Add(unitValue);
                }
            }
            else if(Code == "Gaussian")
            {

            }
            return values;
        }

        public static List<Distribution> SomeDistributions()
        {
            List<Distribution> distributions = new List<Distribution>
            {
                new Distribution("None"),
                new Distribution("Equal"),
                new Distribution("Gaussian"),
                new Distribution("Left Gaussian"),
                new Distribution("Right Gaussian")
            };

            return distributions;
        }
    }
}
