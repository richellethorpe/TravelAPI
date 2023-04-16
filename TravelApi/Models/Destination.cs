using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    [Required]
    public string DestinationName { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Country { get; set; }

    public List<Review> Reviews { get; set; }
  }
}