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
          new Review { ReviewId = 1, DestinationId = 1, Title = "Beautiful Temples", Author = "Bobby B", ReviewBody = "Blah blah blah", starRating = 4},
          new Review { ReviewId = 2, DestinationId = 1, Title = "Big Crowds", Author = "Shelley G", ReviewBody = "Blah de blah de blah", starRating = 5},
          new Review { ReviewId = 3, DestinationId = 2, Title = "Very nice and pretty", Author = "Alex R", ReviewBody = "We done saw that pretty church", starRating = 4},
          new Review { ReviewId = 4, DestinationId = 3, Title = "A+ for game of thrones fans", Author = "Jasmine L", ReviewBody = "Fun trip to see where game of thrones was filmed", starRating = 5},
          new Review { ReviewId = 5, DestinationId = 2, Title = "Great Food", Author = "Tucker B", ReviewBody = "We loved the catherdral and city", starRating = 3},
          new Review { ReviewId = 6, DestinationId = 1, Title = "Too Hot", Author = "Jenny C", ReviewBody = "The weather was scortching", starRating = 1}

        );   
    }


  }
}