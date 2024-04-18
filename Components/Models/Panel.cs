using System.ComponentModel.DataAnnotations;

namespace FrontBlazor.Components.Models
{
    public class Panel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del modelo es obligatorio")]
        public string NombreModelo { get; set; }
        [Required(ErrorMessage = "Es necesario introducir las dimensiones del panel")]
        [Range(1, 10000, ErrorMessage = "El largo del panel debe tener un valor positivo en milímetros")]
        public int Largo { get; set; }
        [Required(ErrorMessage = "Es necesario introducir las dimensiones del panel")]
        [Range(1, 10000, ErrorMessage = "El ancho del panel debe tener un valor positivo en milímetros")]
        public int Ancho { get; set; }
        [Required(ErrorMessage = "Es necesario introducir la potencia pico del panel")]
        [Range(1, 10000, ErrorMessage = "La potencia debe tener un valor positivo")]
        public int Potencia { get; set; }
        [Required(ErrorMessage = "Es necesario introducir el voltaje")]
        [Range(1, 10000, ErrorMessage = "El voltaje debe ser positivo")]
        public double Voltaje { get; set; }
        [Required(ErrorMessage = "El nombre del modelo es obligatorio")]
        public string Material { get; set; }


    }
}
