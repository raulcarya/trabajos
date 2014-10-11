using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apppersona1
{
    class Persona
    {
        //declarar atributos
        string nombre;
        int edad;

        //constructor vacio
        public Persona()
        {
        
        }

        //constructor con parametros
        public Persona(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // metodos get y set
        public string Nombre

        {
            get 
            { 
                return nombre; 
            }

            set
            {
                nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad= value;
            }
        }

        // metodos transaciones





    }
}
