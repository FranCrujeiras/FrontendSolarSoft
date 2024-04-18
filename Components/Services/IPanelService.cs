using FrontBlazor.Components.Models;

namespace FrontBlazor.Components.Services
{
    public interface IPanelService
    {
        Task<Models.Panel[]> GetPanels();
        Task<Models.Panel> GetPanel(int Id);
        Task<bool> PostPanel(Panel panel);
        Task<bool> PutLargo(int Id, int Largo);
        Task<bool> PutAncho(int Id, int Ancho);
        Task<bool> PutPotencia(int Id, int Potencia);
        Task<bool> PutVoltaje(int Id, double Voltaje);
        Task<bool> PutNombreModelo(int Id, string NombreModelo);
        Task<bool> PutMaterial(int Id, string Material);
        Task<bool> DeletePanel(int Id);
    }
}