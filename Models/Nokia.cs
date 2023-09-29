using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Celular.Models
{
	public class Nokia : Smartphone
	{
		//Construtor por herança
		public Nokia (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

		//Polimorfismo do método InstalarAplicativo da classe Abstrata Smartphone
		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
		}

	}
}