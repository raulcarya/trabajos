using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector;
            Console.WriteLine("prograa vector 100");
            Console.WriteLine("digitar el tamaño del vector");

            int tamano,contador,contador3=0;
            tamano = int.Parse(Console.ReadLine());
            vector = new int[tamano];
            for (contador = 0; contador <= tamano - 1; contador++)
            {
                Console.WriteLine("digite numero");
                vector[contador]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el vector es:");
             foreach(int contador2 in vector)

             {  
             Console.WriteLine(contador2);
             if (contador2 > 100)
             {
                 contador3 = contador3 + 1;    
             }

             }



             Console.WriteLine("los numeros mayores de 100 son:"+contador3);
             Console.ReadKey();

            }
     
        
        


    }
}
