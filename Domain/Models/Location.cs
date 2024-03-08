namespace Domain.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        // Propiedades adicionales (opcionales)
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? ContactName { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }

        // Relaciones (opcionales)
        //public virtual ICollection<Car> Cars { get; set; }
    }
}
