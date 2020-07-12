using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmallGames
{

    public enum Direction
    {
        None = 0, Left = 1, Right = 2, Down = 3, Up = 4
    }

    public static class Tools
    {
        public const double G = 6.67398 * 0.00000000001;

        static readonly Random rand = new Random(DateTime.Now.Millisecond);
        public static int GetRandomNo()
        {
            return rand.Next();
        }

        public static int GetRandomNo(int maxSkipBeforeReturn)
        {
            var skipping = rand.Next() % maxSkipBeforeReturn;
            for (int i = 0; i < skipping; i++)
                rand.Next();
            return rand.Next();
        }

        private static int increment = 0;
        public static int GetKindOfUniqueId()
        {
            increment++;
            return (int)(DateTime.Now.AddSeconds(Tools.GetRandomNo(10) % 100).Ticks + Tools.GetRandomNo(10)) % int.MaxValue + increment;
        }

    }
}
