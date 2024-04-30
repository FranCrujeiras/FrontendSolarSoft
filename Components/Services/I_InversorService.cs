using FrontBlazor.Components.Models;

namespace FrontBlazor.Components.Services
{
    public interface I_InversorService
    {
        List<Inversor> GetInversors();
        Inversor GetInversor(int Id);
        Task<bool> PostInversor(Inversor inversor);
        Task<bool> PutPotenciaEntrada(int Id, double PotenciaEntrada);
        Task<bool> PotenciaSalida(int Id, double PotenciaSalida);
        Task<bool> PutVoltajeMinimoMPPT(int Id, int VoltajeMinimoMPPT);
        Task<bool> PutVoltajeMaximoMPPT(int Id, int VoltajeMaximoMPPT);
        Task<bool> PutModeloInversor(int Id, string ModeloInversor);
        Task<bool> PutNumeroMPPT(int Id, int NumeroMPPT);
        Task<bool> DeleteInversor(int Id);
    }
}
