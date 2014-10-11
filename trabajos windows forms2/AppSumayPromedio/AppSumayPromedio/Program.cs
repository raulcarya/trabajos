using System;

namespace AppSumayPromedio
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num1, num2, num3, num4, suma, promedio;
			Console.WriteLine (" Programa que suma 4 numeros y saca el promedio");
			Console.WriteLine ("Digite el numero uno:");
			num1 = double.Parse (Console.ReadLine());
			Console.WriteLine ("Digite el numero dos:");
			num2 = double.Parse (Console.ReadLine());
			Console.WriteLine ("Digite el numero tres:");
			num3 = double.Parse (Console.ReadLine());
			Console.WriteLine ("Digite el numero cuatro:");
			num4 = double.Parse (Console.ReadLine());
			suma = num1 + num2 + num3 + num4;
			promedio = suma / 4;
			Console.WriteLine ("la suma es:" + suma + "el promedio es:" + promedio);
			Console.ReadKey();

		}
	}
}
