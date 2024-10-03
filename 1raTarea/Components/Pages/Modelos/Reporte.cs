using System.ComponentModel.DataAnnotations;
namespace Components.Pages.Modelos
{

    public class Reporte
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int VehiculosInvolucrados { get; set; }
        public int Muertos { get; set; }
        public int Heridos { get; set; }
        public decimal CostoEstimado { get; set; }
    }
}