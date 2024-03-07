namespace MilesCarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public int Year { get; set; }
        public int CategoryId { get; set; }
        public int LocationId { get; set; }

        //public virtual Category Category { get; set; }
        public virtual Location? Location { get; set; }
    }

}
