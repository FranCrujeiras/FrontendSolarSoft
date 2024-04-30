

using FrontBlazor.Components.Models;

namespace FrontBlazor.Components.Services
{
    public interface IBateriaService
    {            
        List<Bateria> GetBateria();
        Bateria GetBateria(int Id);
        Task<bool> PostBateria(Bateria bateria);
        Task<bool> PutCapacidad(int Id, double Capacidad);
        Task<bool> PotenciaSalida(int Id, double PotenciaSalida);
        Task<bool> Modulos(int Id, int Modulos);
        Task<bool> ModeloBateria(int Id, string ModeloBateria);
        Task<bool> PutVoltajeNominal(int Id, double NumeroMPPT);
        Task<bool> DeleteInversor(int Id);
    }
}

