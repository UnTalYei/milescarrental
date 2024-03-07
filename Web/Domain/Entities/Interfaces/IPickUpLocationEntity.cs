namespace MilesCarRental.Domain.Entities.Interfaces
{
    public interface IPickUpLocationEntity
    {
    }

    public interface IPickUpLocation : IPickUpLocationEntity
    {
        string ObtenerInformacionCompleta();
        bool Reservar(int cantidadPersonas);
    }

    public class LocalidadRecogidaEntity : IPickUpLocation
    {
        // Propiedades de la entidad
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int? Capacidad { get; set; }
        // ...

        public string ObtenerInformacionCompleta()
        {
            return $"Nombre: {Nombre}\nDirección: {Direccion}\nCapacidad: {Capacidad}";
        }

        public bool Reservar(int cantidadPersonas)
        {
            if (Capacidad < cantidadPersonas)
                return false;

            // Registrar la reserva en el sistema
            // ...

            return true;
        }
    }
}
