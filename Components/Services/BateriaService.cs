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

        public List<Bateria> GetBaterias()
        {
            var response = HttpClient.GetAsync("GetBaterias").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var ListaBaterias = JsonConvert.DeserializeObject<List<Bateria>>(json);

                return ListaBaterias;
            }
            else
            {
                return null;
            }
        }

        public Bateria GetBateria(int Id)
        {
            var response = HttpClient.GetAsync($"GetBateria/{Id}").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                var bateria = JsonConvert.DeserializeObject<Bateria>(json);

                return bateria;
            }
            else
            {
                return null;
            }
        }

        public bool PostBateria(Bateria bateria)
        {
            var response = HttpClient.PostAsJsonAsync("PostBateria", bateria).Result;
            return response.IsSuccessStatusCode;
        }

        public bool PutCapacidad(int Id, double Capacidad)
        {
            throw new NotImplementedException();
        }

        public bool PotenciaSalida(int Id, double PotenciaSalida)
        {
            throw new NotImplementedException();
        }

        public bool Modulos(int Id, int Modulos)
        {
            throw new NotImplementedException();
        }

        public bool ModeloBateria(int Id, string ModeloBateria)
        {
            throw new NotImplementedException();
        }

        public bool PutVoltajeNominal(int Id, double VoltajeNominal)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInversor(int Id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, double[]> GetPatrones()
        {
            Dictionary<string, double[]> patrones = new Dictionary<string, double[]>();
            var response = HttpClient.GetAsync($"GetPatrones").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                patrones = JsonConvert.DeserializeObject<Dictionary<string, double[]>>(json);
                return patrones;
            }
            else
            {
                return null;
            }
        }

        public double[] GetPatron(string Patron)
        {
            double[] patron = null;
            var response = HttpClient.GetAsync($"GetPatron/{Patron}").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                patron = JsonConvert.DeserializeObject<double[]>(json);
                return patron;
            }
            else
            {
                return null;
            }
        }

        public bool ConsumoMensual(int Id, double ConsumoMensual)
        {
            throw new NotImplementedException();
        }
    }
}

