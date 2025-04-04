using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System;

namespace Event_Ease.Models
{
    public class Booking
    {
        [Key] public int BookingId { get; set; }
        public int EventId { get; set; }
        public Event? Event { get; set; }
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }
        public String? BookingDate { get; set; }
    }
}
