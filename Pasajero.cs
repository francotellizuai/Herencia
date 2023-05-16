using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Pasajero
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        public Pasajero(string nombre, string apellido, int edad) {
            this.nombre = nombre;
            this.apellido = apellido;  
            this.edad = edad;
        }

        public string Nombre 
        { 
            set { this.nombre = value; }
            get {  return nombre; }
        }    

        public string Apellido
        {
            set { this.apellido = value; } 
            get { return apellido; }
        }

        public int Edad
        {
            set { this.edad = value; }
            get { return edad; }
        }

    }
}
