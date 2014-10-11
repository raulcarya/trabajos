using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumero
{
    class Numero
    {

        //atributos

        int numeromayor;
        int numeromenor;

        //constructor con parametros

        public Numero(int numeromenor, int numeromayor)

        {

            this.numeromenor = numeromenor;
            this.numeromayor = numeromayor;
        }


        //metodo get y set

        public int Numeromenor

        {
            get
            {
                return numeromenor;

            }

            set 
            {
                numeromenor = value;
            }

        }

        public int Numeromayor
        {
            get
            {
                return numeromayor;

            }

            set
            {
                numeromayor = value;
            }

        }


        //metodo transacional = operaciones

        public List<int> MostrarRango()
        {
            List<int> rango = new List<int>();
            for (int contador = numeromenor; contador <= numeromayor; contador++)

            {
                rango.Add(contador);
            }
            return rango;
       }
    }
}
