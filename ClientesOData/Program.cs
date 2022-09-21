using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercitoOData.Models;

namespace ClientesOData
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /*static async Task ListPeople()
        {
            var serviceRoot = "https://localhost:44306/odata/ejercitos/";
            var context = new DefaultContainer(new Uri(serviceRoot));

            IEnumerable<Ejercito> people = await context.People.ExecuteAsync();
            foreach (var person in people)
            {
                Console.WriteLine("{0} {1}", person.Id, person.Nombre);
            }
        }*/
    }
}
