using System.ComponentModel.DataAnnotations;

namespace Event_Ease.Models
{
    public class Venue
    {
        [Key] public int VenueId { get; set; }

        public String? VenueName { get; set; }
        public String Location { get; set; }
        public int? Capacity { get; set; }
        public String ImageUrl { get; set; }

        public List<Booking> Bookings { get; set; } = new();
    }
}
