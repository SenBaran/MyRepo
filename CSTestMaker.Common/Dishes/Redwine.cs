using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTestMaker.Common.Dishes
{
    public class Redwine : DishObject
    {
        public bool IsPoured { get; set; }

        public static Task<Redwine> PourAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Is pouring");
                Task.Delay(1000).Wait();
                Console.WriteLine("Redwine poured");
                return new Redwine()
                {
                    IsPoured = true,
                };
            });
        }
    }
}
