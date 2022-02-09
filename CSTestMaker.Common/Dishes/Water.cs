using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTestMaker.Common.Dishes
{
    public class Water : DishObject
    {
        public bool IsPoured { get; private set; }

        public static Task<Water> PourAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Pouring water");
                Task.Delay(1000).Wait();
                Console.WriteLine("Water ready");
                return new Water()
                {
                    IsPoured = true,
                };
            });
        }
    }
}
