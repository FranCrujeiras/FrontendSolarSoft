using FrontBlazor.Components.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FrontBlazor.Components.Services
{
    public class InversorService : I_InversorService
    {
        private HttpClient HttpClient { get; set; }
        public InversorService(HttpClient httpClient)
        {
            HttpClient = httpClient;
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public Task<bool> DeleteInversor(int Id)
        {
            throw new NotImplementedException();
        }

        public Inversor GetInversor(int Id)
        {
            var response = HttpClient.GetAsync($"GetInversores/{Id}").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var panel = JsonConvert.DeserializeObject<Inversor>(json);

                return panel;
            }
            else
            {
                return null;
            }
        }


        public List<Inversor> GetInversor()
        {
            var response = HttpClient.GetAsync("GetInversor").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var ListaInversores = JsonConvert.DeserializeObject<List<Inversor>>(json);

                return ListaInversores;
            }
            else
            {
                return null;
            }

        }

        //Casi lo tienes!! Cambia la URL del POST en la API a Paneles/PostPanel, en vez de /Paneles, la funcionalidad va como debería!
        public async Task<bool> PostInversor(Inversor inversor)
        {
            var response = HttpClient.PostAsJsonAsync("PostInversor", inversor).Result;
            return response.IsSuccessStatusCode;
        }

        public List<Inversor> GetInversors()
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutPotenciaEntrada(int Id, double PotenciaEntrada)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PotenciaSalida(int Id, double PotenciaSalida)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutVoltajeMinimoMPPT(int Id, int VoltajeMinimoMPPT)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutVoltajeMaximoMPPT(int Id, int VoltajeMaximoMPPT)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutModeloInversor(int Id, string ModeloInversor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutNumeroMPPT(int Id, int NumeroMPPT)
        {
            throw new NotImplementedException();
        }
    }
}

