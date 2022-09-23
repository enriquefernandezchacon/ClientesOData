using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercitoOData.Models;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace ClienteWebOData.Data
{
    public class ClienteWebODataContext : DbContext
    {
        public ClienteWebODataContext (DbContextOptions<ClienteWebODataContext> options)
            : base(options)
        {
        }

        public DbSet<EjercitoOData.Models.Ejercito> Ejercito { get; set; }
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
            nuevoEjercito.Id = _ejercitos.Count() + 1;
            var json = JsonSerializer.Serialize(nuevoEjercito);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://localhost:44306/odata/ejercitos";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);
        }
    }
}
