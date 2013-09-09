using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Destination> ds;
            using (var context = new MyDbContext())
            {
                ds = context.Destinations.ToList();
                Console.WriteLine(context.Destinations.Local.Count);
            }

            using (var context=new MyDbContext())
            {
                Console.WriteLine(context.Destinations.Local.Count);
            }
            Console.WriteLine("111");
            Console.ReadKey(false);
        }
    }
}
