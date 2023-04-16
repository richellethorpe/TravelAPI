using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
        .HasData(
          new Destination { DestinationId = 1, DestinationName = "Wat Pho", City = "Bangkok", Country = "Thailand" },
          new Destination { DestinationId = 2, DestinationName = "Cathedral of Our Lady of Strasbourg", City = "Strasbourg", Country = "France" },
          new Destination { DestinationId = 3, DestinationName = "Trsteno Arboretum", City = "Dubrovnik", Country = "Croatia" }
        );

     builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, DestinationId = 1, Title = "Beautiful Temples", Author = "TestPerson 1", ReviewBody = "Blah blah blah", starRating = 4},
          new Review { ReviewId = 2, DestinationId = 1, Title = "Big Crowds", Author = "TestPerson 2", ReviewBody = "Blah de blah de blah", starRating = 5}

        );   
    }


  }
}