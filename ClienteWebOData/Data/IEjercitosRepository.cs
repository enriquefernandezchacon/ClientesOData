using ClienteWebOData.Models;
using EjercitoOData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteWebOData.Data
{
    public interface IEjercitosRepository
    {
        IList<Ejercito> GetEjercitos();
        Ejercito Find(int? id);
        void Anadir(Ejercito nuevoEjercito);
        public void Remove(int id);
    }
}
