using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Persona
    {
        public int Edad { get; set;}
        public string Nombre { get; set; }

        public Persona(int edad, string nombre)
        {
            this.Edad = edad; /* "this" hace referencia a la Edad de la clase; 
                                la Edad sin "this" es la Edad del constructor*/
            this.Nombre = nombre;
        }

        public Persona()
        {
            this.Edad = 0;
            this.Nombre = "";
        }

        public void cumplirAño()
        {
            this.Edad++;
        }
    }
}
