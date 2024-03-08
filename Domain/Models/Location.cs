namespace Domain.Models
{
    public class Location
    {
        public int Id { get; set; } // Primary Key (auto-incrementing)
        public required string Name { get; set; } // Not null
        public string? Address { get; set; } // Optional
        public double? Latitude { get; set; } // Optional
        public double? Longitude { get; set; } // Optional
        public string? PhoneNumber { get; set; } // Optional
        public string? Email { get; set; } // Optional
        public string? BusinessHours { get; set; } // Optional
        public int? Capacity { get; set; } // Optional (nullable int)
        public string? Restrictions { get; set; } // Optional

        // Relaciones (opcionales)
        //public virtual ICollection<Car> Cars { get; set; }
    }
}
