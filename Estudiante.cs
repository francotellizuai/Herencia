using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Estudiante:Pasajero
    {
        private int numero_legajo;
        private string institucion;

        public Estudiante( string nombre, string apellido, int edad, int numero_legajo, string institucion):base(nombre, apellido, edad) {
            this.institucion = institucion;
            this.numero_legajo = numero_legajo;
        }


        public int NumeroLegajo
        {
            set { this.numero_legajo = value; }
            get { return numero_legajo; }
        }

        public string Institucion
        {
            set { this.institucion = value; }
            get { return institucion; }
        }

        public override string ToString()
        { 
            return "Nombre: " +this.Nombre + "\nApellido: " + this.Apellido + "\nEdad: " + this.Edad + "\nNumeroLegajo: " + this.numero_legajo + "\nInstitucion: " + this.institucion;
        }

    }
}
