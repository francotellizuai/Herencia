using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Colectivo
    {
        public List<Pasajero> pasajeros;

        public Colectivo() 
        {
            pasajeros = new List<Pasajero>();
        }

        public void VenderBoleto(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }

        public int GetCantidadPasajeros()
        {
            return pasajeros.Count;
        }

    }
}
