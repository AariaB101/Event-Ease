using System.ComponentModel.DataAnnotations;

namespace Event_Ease.Models
{
    public class Event
    {
        [Key] public int EventId { get; set; }

        public String? EventName { get; set; }
        public String EventDate { get; set; }
        public String? Description { get; set; }
        public List<Booking> Bookings { get; set; } = new();
    }
}
