using EjercitoOData.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesOData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListEjercitos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        async Task ListEjercitos()
        {
            var serviceRoot = "https://localhost:44306/odata/Ejercitos";
            var context = new Default.Container(new Uri(serviceRoot));

            IEnumerable<Ejercito> people = await context.Ejercitos.ExecuteAsync();
            int contador = 1;
            foreach (var person in people)
            {
                if (contador == 1)
                {
                    this.textBox1.Text = person.Id + " - " + person.Nombre;
                    contador++;
                } else if (contador == 2)
                {
                    this.textBox1.Text = person.Id + " - " + person.Nombre;
                    contador++;
                }
            }
        }
    }
}
