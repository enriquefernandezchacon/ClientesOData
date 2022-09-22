using EjercitoOData.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesOData
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        List<Ejercito> _ejercitos { get; set; }
        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Fecha de Nacimiento");
            dt.Columns.Add("Fuerza de Combate");
            dt.Columns.Add("Ubicacion");
            this.dataGridView1.DataSource = dt;
            LlamarOdata();
            CargarGrid();
            CargarResumen();
            CargarMasFuerte();
        }

        private void LlamarOdata()
        {
            var serviceRoot = "https://localhost:44306/odata";
            var context = new Default.Container(new Uri(serviceRoot));

            var ejercitos = context.Ejercitos.Select(x => x);
            _ejercitos = ejercitos.ToList();
        }        

        private void CargarGrid()
        {
            dt.Clear();
            foreach (var ejercito in _ejercitos)
            {
                DataRow dr = dt.NewRow();
                dr[0] = ejercito.Id;
                dr[1] = ejercito.Nombre;
                dr[2] = ejercito.FechaNacimiento.ToString("d");
                dr[3] = ejercito.FuerzaCombate;
                dr[4] = ejercito.Ubicacion;
                dt.Rows.Add(dr);
            }            
        }
        private void CargarResumen()
        {
            this.textBoxNumEjercitos.Text = _ejercitos.Count().ToString();
            this.textBoxFuerzaTotal.Text = _ejercitos.Sum(x => x.FuerzaCombate).ToString("0.00");
            this.textBoxFuerzaMedia.Text = _ejercitos.Average(x => x.FuerzaCombate).ToString("0.00");
            this.textBoxAnosTotales.Text = _ejercitos.Sum(x => (DateTimeOffset.Now - x.FechaNacimiento).TotalDays / 365).ToString("0.00");
            this.textBoxAnosMedia.Text = _ejercitos.Average(x => (DateTimeOffset.Now - x.FechaNacimiento).TotalDays / 365).ToString("0.00");
        }

        private void CargarMasFuerte()
        {
            var ejercitoMasFuerte = _ejercitos.OrderByDescending(x => x.FuerzaCombate).FirstOrDefault();
            this.textBoxId.Text = ejercitoMasFuerte.Id.ToString();
            this.textBoxNombre.Text = ejercitoMasFuerte.Nombre;
            this.textBoxFechaNac.Text = ejercitoMasFuerte.FechaNacimiento.ToString("d");
            this.textBoxFuerza.Text = ejercitoMasFuerte.FuerzaCombate.ToString();
            this.textBoxUbicacion.Text = ejercitoMasFuerte.Ubicacion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void AnadirEjercitoAsync(object sender, EventArgs e)
        {
            if (textBoxNombreAdd.Text.Trim() != "" && textBoxIdAdd.Text.Trim() != "" && textBoxFuerzaAdd.Text.Trim() != "" && textBoxUbicacionAdd.Text.Trim() != "" && dateTimePicker1 is not null)
            {
                int id;
                float fuerza;
                if (Int32.TryParse(textBoxIdAdd.Text, out id) && float.TryParse(textBoxFuerzaAdd.Text, out fuerza))
                {
                    try
                    {
                        var nuevoEjercito = new Ejercito()
                        {
                            Id = Int32.Parse(textBoxIdAdd.Text),
                            Nombre = textBoxNombreAdd.Text,
                            FechaNacimiento = dateTimePicker1.Value,
                            FuerzaCombate = float.Parse(textBoxFuerzaAdd.Text),
                            Ubicacion = textBoxUbicacionAdd.Text
                        };

                        var json = JsonSerializer.Serialize(nuevoEjercito);
                        var data = new StringContent(json, Encoding.UTF8, "application/json");

                        var url = "https://localhost:44306/odata/ejercitos";
                        using var client = new HttpClient();

                        var response = await client.PostAsync(url, data);

                        if (response.StatusCode == HttpStatusCode.Created)
                        {
                            System.Windows.Forms.MessageBox.Show("Ejercito añadido con exito");
                        } else
                        {
                            System.Windows.Forms.MessageBox.Show("ERROR: " + response.StatusCode);
                        }
                        

                        LlamarOdata();
                        CargarGrid();
                        CargarResumen();
                        CargarMasFuerte();
                    }
                    catch (Exception er)
                    {
                        System.Windows.Forms.MessageBox.Show("Error:" + er.Message);
                    }
                } else
                {
                    System.Windows.Forms.MessageBox.Show("El campo id o fuerza no posee un valor numérico");
                }
            } else
            {
                System.Windows.Forms.MessageBox.Show("No es posible añadir, hay campos vacíos");
            }
        }
    }
}
