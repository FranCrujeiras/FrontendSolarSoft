using FrontBlazor.Components.Models;

namespace FrontBlazor.Components.Services
{
    public interface ITerrenoService
    {
        #region GETs
        Task<Models.Terreno[]> GetTerrenos();
        Task<Models.Terreno> GetTerreno(int Id);
        string GetDataPVGIS(Terreno terreno);
        #endregion
        #region POSTs
        Terreno PostTerreno(Terreno terreno);
        #endregion
        #region PUTs
        Task<bool> PutLatitud(int Id, double Latitud);
        Task<bool> PutLongitud(int Id, double Longitud);
        Task<bool> PutAnchoTerreno(int Id, double AnchoTerreno);
        Task<bool> PutLargoTerreno(int Id, double LargoTerreno);
        Task<bool> PutAnguloEstructura(int Id, int AnguloEstructura);
        #endregion
        #region DELETE
        Task<bool> DeletePanel(int Id);
        #endregion
    }
}
