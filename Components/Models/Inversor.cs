using System.ComponentModel.DataAnnotations;

namespace FrontBlazor.Components.Models
{
    public class Inversor
    {
        //Recuerda añadir un int para los ID!!
        public int Id { get; set; }
        //Nombre del modelo de inversor
        [Required(ErrorMessage = "El nombre del modelo es obligatorio")]
        public string ModeloInversor { get; set; }

        //Porcentaje de eficiencia según norma europea
        [Required(ErrorMessage = "Es necesario especificar la eficiencia europea")]
        public double EficienciaEuropea { get; set; }
        //Potencia máxima de entrada al inversor
        [Required(ErrorMessage = "Es necesario especificar la potencia de entrada")]
        public double PotenciaEntrada { get; set; }
        //Voltaje mínimo por string necesario para operar el inversor
        [Required(ErrorMessage = "Es necesario especificar el voltaje mínimo MPPT")]
        public int VoltajeMinimoMPPT { get; set; }
        //Voltaje máximo por string para operar el inversor
        [Required(ErrorMessage = "Es necesario especificar el voltaje máximo MPPT")]
        public int VoltajeMaximoMPPT { get; set; }
        //Potencia de salida del inversor
        [Required(ErrorMessage = "Es necesario especificar la potencia de salida")]
        public double PotenciaSalida { get; set; }
        //Número de Strings que admite el inversor
        [Required(ErrorMessage = "Es necesario especificar el número de MPPT")]
        public int NumeroMPPT { get; set; }
    }
}
