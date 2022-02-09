using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTestMaker.Common.Dishes
{
    public class Toast : DishObject
    {
        public bool IsToasted { get; set; }

        public static Task<Toast> ToastBreadAsync()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Toasting");
                Task.Delay(10000).Wait();
                Console.WriteLine("Finished Toasting");
                return new Toast() 
                { 
                    IsToasted = true 
                };
            });
        }
    }
}
