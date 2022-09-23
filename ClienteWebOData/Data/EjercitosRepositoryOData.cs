using ClienteWebOData.Models;
using EjercitoOData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ClienteWebOData.Data
{
    public class EjercitosRepositoryOData : IEjercitosRepository
    {
        private IList<Ejercito> _ejercitos { get; set; }

        private void CargarEjercitos()
        {
            var serviceRoot = "https://localhost:44306/odata";
            var context = new Default.Container(new Uri(serviceRoot));

            _ejercitos = context.Ejercitos.Select(x => x).ToList();
        }
        public IList<Ejercito> GetEjercitos()
        {
            CargarEjercitos();
            return _ejercitos;
        }

        public Ejercito Find(int? id)
        {
            CargarEjercitos();
            var ejercito = _ejercitos.ToList().Find(x => x.Id == id);
            return ejercito;
        }

        public async void Anadir(Ejercito nuevoEjercito)
        {
            CargarEjercitos();
            nuevoEjercito.Id = _ejercitos.OrderByDescending(x => x.Id).Take(1).FirstOrDefault().Id + 1;
            var json = JsonSerializer.Serialize(nuevoEjercito);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://localhost:44306/odata/ejercitos";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);
            CargarEjercitos();
        }

        public async void Remove(int id)
        {
            var json = JsonSerializer.Serialize(new Ejercito() { Id = id });
            HttpRequestMessage request = new HttpRequestMessage
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:44306/odata/ejercitos(" + id + ")")
            };
            var client = new HttpClient();
            var p = await client.SendAsync(request);
            CargarEjercitos();
        }
    }
}
