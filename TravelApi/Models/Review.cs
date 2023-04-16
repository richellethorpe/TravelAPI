using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TravelApi.Models
{
  public class Review
  {
    public int DestinationId { get; set; }

    public int ReviewId { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Author { get; set; }

    [Required]

    public string ReviewBody { get; set; }

    [Required]
    [Range(1,5, ErrorMessage = "Must provide a 1-5 start rating.")]
    public int starRating { get; set; }
    [JsonIgnore]
    public Destination destination { get; set; }
  }
}