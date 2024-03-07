using MilesCarRental.Domain.Entities.Interfaces;

namespace MilesCarRental.Domain.Entities
{
    public class PickUpLocationEntity : IPickUpLocationEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string HorarioAtencion { get; set; }
        public int? Capacidad { get; set; }
        public string? Restricciones { get; set; }

        //public PickUpLocationEntity()
        //{
        //}
        public bool Validar()
        {
            // Validaciones específicas de la entidad
            if (string.IsNullOrEmpty(Nombre))
                return false;

            if (string.IsNullOrEmpty(Direccion))
                return false;

            // ...
            return true;
        }

        public PickUpLocationEntity(string nombre, string direccion, string telefono, string email, string horarioAtencion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            HorarioAtencion = horarioAtencion;
        }

        public override string ToString()
        {
            return $"Localidad de Recogida: {Nombre} ({Direccion})";
        }
    }
}
