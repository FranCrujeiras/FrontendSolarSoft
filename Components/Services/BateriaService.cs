using FrontBlazor.Components.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FrontBlazor.Components.Services
{
    public class BateriaService : IBateriaService
    {
        private HttpClient HttpClient { get; set; }
        public BateriaService(HttpClient httpClient)
        {
            HttpClient = httpClient;
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public Task<bool> DeleteInversor(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Bateria> GetBateria()
        {
            throw new NotImplementedException();
        }

        public Bateria GetBateria(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ModeloBateria(int Id, string ModeloBateria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modulos(int Id, int Modulos)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PostBateria(Bateria bateria)
        {
            var response = HttpClient.PostAsJsonAsync("PostBateria", bateria).Result;
            return response.IsSuccessStatusCode;
        }

        public Task<bool> PotenciaSalida(int Id, double PotenciaSalida)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutCapacidad(int Id, double Capacidad)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutVoltajeNominal(int Id, double NumeroMPPT)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostBateria(SolarSoft_1._0.Models.Bateria bateria)
        {
            throw new NotImplementedException();
        }
    }
}

