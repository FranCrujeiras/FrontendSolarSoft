using FrontBlazor.Components.Models;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace FrontBlazor.Components.Services
{
    public class TerrenoService : ITerrenoService
    {
        private readonly HttpClient HttpClient;

        public TerrenoService(HttpClient httpClient)
        {
            HttpClient = httpClient;
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public Task<bool> DeletePanel(int Id)
        {
            throw new NotImplementedException();
        }

        public string GetDataPVGIS(Terreno terreno)
        {
            HttpClient cliente = new HttpClient()
            {
                BaseAddress = new Uri("Https://re.jrc.ec.europa.eu/api/")
            };
            var mounting = terreno.InstalacionEstructura ? "building" : "free";
            var response = cliente.GetAsync($"PVcalc?lat={terreno.Latitud.ToString().Replace(",", ".")}&lon={terreno.Longitud.ToString().Replace(",", ".")}&peakpower={terreno.PotenciaTotal.ToString().Replace(",", ".")}&mountingplace={mounting}&loss=14&angle={terreno.AnguloEstructura}&aspect={terreno.Azimuth}&outputformat=json").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            return null;         
        }       
        public Task<Terreno> GetTerreno(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Terreno[]> GetTerrenos()
        {
            var response = HttpClient.GetAsync("GetTerreno").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var terrenos = JsonConvert.DeserializeObject<Terreno[]>(json);
                return terrenos;
            }
            return null;
        }

        public Terreno PostTerreno(Terreno terreno)
        {
            var response = HttpClient.PostAsJsonAsync("PostTerreno", terreno).Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Terreno>(content);
            }
            else
            {
                return null;
            }
        }

        public Task<bool> PutAnchoTerreno(int Id, double AnchoTerreno)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutAnguloEstructura(int Id, int AnguloEstructura)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutLargoTerreno(int Id, double LargoTerreno)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutLatitud(int Id, double Latitud)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutLongitud(int Id, double Longitud)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutModeloPanel(int Id, string ModeloPanel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutPotenciaPanel(int Id, int PotenciaPanel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutVoltajePanel(int Id, double VoltajePanel)
        {
            throw new NotImplementedException();
        }
    }
}
