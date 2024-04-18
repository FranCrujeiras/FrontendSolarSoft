using FrontBlazor.Components.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FrontBlazor.Components.Services
{
    public class PanelService : IPanelService

    {
        private HttpClient HttpClient { get; set; }
        public PanelService(HttpClient httpClient) 
        {
            HttpClient = httpClient;
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public Task<bool> DeletePanel(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Panel> GetPanel(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Panel[]> GetPanels()
        {
            throw new NotImplementedException();
        }

        //Casi lo tienes!! Cambia la URL del POST en la API a Paneles/PostPanel, en vez de /Paneles, la funcionalidad va como debería!
        public async Task<bool> PostPanel(Panel panel)
        {
            var response = HttpClient.PostAsJsonAsync("PostPanel", panel).Result;
            return response.IsSuccessStatusCode;
        }

        public Task<bool> PutAncho(int Id, int Ancho)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutLargo(int Id, int Largo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutMaterial(int Id, string Material)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutNombreModelo(int Id, string NombreModelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutPotencia(int Id, int Potencia)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutVoltaje(int Id, double Voltaje)
        {
            throw new NotImplementedException();
        }
    }
}
