namespace MyVac.WebApi.Models
{
    public class RegistroVacuna
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public Persona? Persona { get; set; }

        public int VacunaId { get; set; }
        public Vacuna? Vacuna { get; set; }

        public DateTime FechaAplicacion { get; set; }
        public int NumeroDosis { get; set; }
    }
}