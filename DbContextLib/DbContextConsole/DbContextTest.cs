using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextConsole
{
    [Table("Locations", Schema = "baga")]
    public class Destination
    {
        public Destination()
        {
            this.Lodgings = new List<Lodging>();
        }
        [Column("LocationID")]
        public int DestinationId { get; set; }
        [Required, Column("LocationName")]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Country { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        public string TravelWarnings { get; set; }
        public string ClimateInfo { get; set; }
        public List<Lodging> Lodgings { get; set; }
    }
    public class Lodging
    {
        public int LodgingId { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Name { get; set; }
        public string Owner { get; set; }
        //public decimal MilesFromNearestAirport { get; set; }
        //[Column("destination_id")]
        //public int DestinationId { get; set; }
        //public Destination Destination { get; set; }
        //public List<InternetSpecial> InternetSpecials { get; set; }
        //public int? PrimaryContactId { get; set; }
        //[InverseProperty("PrimaryContactFor")]
        //[ForeignKey("PrimaryContactId")]
        //public Person PrimaryContact { get; set; }
        //public int? SecondaryContactId { get; set; }
        //[InverseProperty("SecondaryContactFor")]
        //[ForeignKey("SecondaryContactId")]
        //public Person SecondaryContact { get; set; }
    }
    public class Person
    {
        public int PersonId { get; set; }
    }
    public class InternetSpecial
    {
        public int InternetSpecialId { get; set; }
    }

    public class MyDbContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<InternetSpecial> InternetSpecials { get; set; }
        public MyDbContext()
            : base()
        {
            Destinations.Local.CollectionChanged += (sender, args) =>
                {
                    if (args.NewItems != null && args.Action == NotifyCollectionChangedAction.Add)
                    {
                        Console.WriteLine(args.NewItems.OfType<Destination>().Select(c => c.Name).FirstOrDefault());
                    }
                };
        }
    }
}
