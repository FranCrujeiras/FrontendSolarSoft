using System.ComponentModel.DataAnnotations;

namespace FrontBlazor.Components.Models
{
    public class Terreno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es obligatorio escoger un modelo de panel")]
        public string ModeloPanel { get; set; }

        [Range(0, 2000, ErrorMessage = "Es necesario especificar la potencia")]
        public int Potencia { get; set; }

        [Range(0, 100, ErrorMessage = "Es necesario especificar el voltaje")]
        public double Voltaje { get; set; }

        [Range(-90, 90, ErrorMessage = "La latitud debe tener un valor entre -90º y 90º")]
        public double Latitud { get; set; }

        [Range(-180, 180, ErrorMessage = "La Longitud debe tener un valor entre -180º y 180º")]
        public double Longitud { get; set; }

        [Range(0, 200000, ErrorMessage = "El valor del largo del terreno debe tener un valor positivo")]
        public double LargoTerreno { get; set; }

        [Range(0, 200000, ErrorMessage = "El valor del ancho del terreno debe tener un valor positivo")]
        public double AnchoTerreno { get; set; }

        [Range(0, 359, ErrorMessage = "El ángulo de azimuth debe estar entre 0º y 359º")]
        public int Azimuth { get; set; }
        
        public bool InstalacionEstructura { get; set; }

        [Range(0, 45, ErrorMessage = "El ángulo de estructura debe tener un valor de 15º o 30º")]
        public int AnguloEstructura { get; set; }

        public double? Separacion { get; set; }

        public int? PotenciaTotal { get; set; }

        public int? TotalPaneles { get; set; }

        public Terreno()
        {

        }
    }

}
