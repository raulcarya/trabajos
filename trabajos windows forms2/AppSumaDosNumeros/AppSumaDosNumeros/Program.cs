using System;

namespace AppSumaDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// declaracio de variables 
			int numero1, numero2, suma;
			string linea;
			Console.WriteLine ("Programa que calcula la suma de 2 numeros");
			Console.WriteLine ("DIGITE EL NUMERO UNO:");
			linea = Console.ReadLine ();
			numero1 = int.Parse (linea);
			Console.WriteLine ("DIGITE EL NUMERO DOS:");
			linea = Console.ReadLine ();
			numero2 = int.Parse (linea);
			suma = numero1 + numero2;
			Console.WriteLine ("LA SUMA ES:" + suma);
			Console.ReadKey ();
			 
			 
		}
	}
}
