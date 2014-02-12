using System.ComponentModel.DataAnnotations;

namespace Datos.Models.Concesionario.Entities
{
    public class CocheEntity
    {
        [Key]
        public int IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public string Fecha { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }

        public int IdConcesionario { get; set; }
        public virtual ConcesionarioEntity Concesionario { get; set; }


        public Contracts.Coche ToDto()
        {
            return new Contracts.Coche
                {
                    IdCoche = IdCoche,
                    Marca = Marca,
                    Modelo = Modelo,
                    Precio = Precio,
                    Fecha = Fecha,
                    Foto = Foto,
                    Descripcion = Descripcion
                };
        }
    }
}