

using FrontBlazor.Components.Models;

namespace FrontBlazor.Components.Services
{
    public interface IBateriaService
    {
        List<Bateria> GetBaterias();
        Bateria GetBateria(int Id);
        bool PostBateria(Bateria bateria);
        bool PutCapacidad(int Id, double Capacidad);
        bool PotenciaSalida(int Id, double PotenciaSalida);
        bool Modulos(int Id, int Modulos);
        bool ModeloBateria(int Id, string ModeloBateria);
        bool PutVoltajeNominal(int Id, double VoltajeNominal);
        bool DeleteInversor(int Id);
        Dictionary<string, double[]> GetPatrones();
        double[] GetPatron(string Patron);
        bool ConsumoMensual(int Id, double ConsumoMensual);
    }
}

