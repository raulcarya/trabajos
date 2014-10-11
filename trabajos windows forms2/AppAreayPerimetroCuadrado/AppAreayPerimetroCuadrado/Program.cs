using System;

namespace AppAreayPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, area, perimetro;
			Console.WriteLine ("Programa que calcula el area y perimetro de un cuadrado");
			Console.WriteLine ("DIgite el lado:");
			lado = float.Parse (Console.ReadLine ());
			area = lado * lado;
			Console.WriteLine ("El are de un cuadrado:"+area);
			perimetro = 4 * area;
			Console.WriteLine ("El perimetro es:" + perimetro);
			Console.ReadKey();
		}
	}
}
