using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF4SqlCompact
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ModelContext())
            {
                var model = new Model()
                {
                    Code = "wangcl",
                    Name = "王春雷"
                };

                context.Models.Add(model);
                context.SaveChanges();
            }
        }
    }

    public class Model
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class ModelContext : DbContext
    {
        public DbSet<Model> Models { get; set; }
    }
}
