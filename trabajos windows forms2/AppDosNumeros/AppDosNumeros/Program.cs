using System;

namespace AppDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1,num2,suma,diferencia,producto,division;
			Console.WriteLine (" Programa mayor de dos numeros");
			Console.WriteLine ("lea numero uno:");
			num1 = int.Parse (Console.ReadLine ());
			Console.WriteLine ("lea numero dos:");
			num2 = int.Parse (Console.ReadLine ());
			if(num1>num2){
				suma = num1 + num2;
				diferencia = num1 - num2;
				Console.WriteLine ("la suma es:"+suma);
				Console.WriteLine ("la diferencia es:" + diferencia);
			}

			else
			{
				producto = num1 * num2;
				division = num1 / num2;
				Console.WriteLine ("el producto es:"+producto);
				Console.WriteLine ("la division es:" + division);
			}
			Console.ReadKey ();

		}
	}
}
