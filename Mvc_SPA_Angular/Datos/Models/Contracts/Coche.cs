

namespace Datos.Models.Contracts
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
    }
    public class Coche : ICoche
    {
        public int IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public string Fecha { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
    }
}