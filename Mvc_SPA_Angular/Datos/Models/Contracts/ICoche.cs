namespace Datos.Models.Contracts
{
    public interface ICoche
    {
        int IdCoche { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        double Precio { get; set; }
    }
}