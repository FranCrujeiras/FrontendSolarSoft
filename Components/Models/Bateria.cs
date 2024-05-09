using System.ComponentModel.DataAnnotations;

namespace FrontBlazor.Components.Models
{
    public class Bateria
    {
        public int Id { get; set; }
        //Nombre del modelo de batería
        [Required(ErrorMessage = "Es necesario introducir el nombre del modelo")]
        public string ModeloBateria { get; set; }
        //Capacidad de la batería en kWh
        [Required(ErrorMessage = "Es necesario especificar la capacidad")]
        public double Capacidad { get; set; }
        //Potencia de salida de la batería en kW
        [Required(ErrorMessage = "Es necesario especificar la potencia de salida")]
        public double PotenciaSalida { get; set; }
        //Número de módulos apilados en el sistema
        [Required(ErrorMessage = "Es necesario especificar el número de módulos")]
        public int Modulos { get; set; }
        //Voltaje nominal de la batería en Voltios
        [Required(ErrorMessage = "Es necesario especificar el voltaje nominal")]
        public int VoltajeNominal { get; set; }
        public double ConsumoMensual {  get; set; }

    }
}
