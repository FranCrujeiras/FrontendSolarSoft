namespace FrontBlazor.Components.Models
{
    public class Terreno
    {
        public int Id { get; set; }        
        public string ModeloPanel { get; set; }
        public int Potencia { get; set; }
        public double Voltaje { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public double LargoTerreno { get; set; }
        public double AnchoTerreno { get; set; }
        public int Azimuth { get; set; }
        public bool InstalacionEstructura { get; set; }
        public int AnguloEstructura { get; set; }
        public double? Separacion { get; set; }
        public int? PotenciaTotal { get; set; }
        public int? TotalPaneles { get; set; }

        public Terreno()
        {

        }
    }
   
}
