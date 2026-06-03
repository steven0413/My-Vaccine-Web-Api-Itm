namespace MyVac.WebApi.Models
{
    public class Vacuna
    {
        public int Id { get; set; }
        public string NombreVacuna { get; set; } = string.Empty;
        public string Laboratorio { get; set; } = string.Empty;
    }
}