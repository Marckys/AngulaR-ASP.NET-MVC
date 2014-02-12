using System.ComponentModel.DataAnnotations;

namespace Datos.Models.Concesionario.Entities
{
    public class ProvinciaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }

        public Contracts.Provincia ToDto()
        {
            return new Contracts.Provincia
            {
                Id = Id,
                Nombre = Nombre,
                Pais = Pais
            };
        }
    }
}