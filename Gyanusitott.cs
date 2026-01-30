using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Gyanusitott
	{
		private Szemely gyanusSzemely;
		private int gyanusitottsag;
		private string statusz;

		public Gyanusitott(Szemely gyanusSzemely, int gyanusitottsag, string statusz)
		{
			this.gyanusSzemely = gyanusSzemely;
			this.gyanusitottsag = gyanusitottsag;
			this.statusz = statusz;
		}

		public void Donteshozo(Bizonyitek b)
		{
			this.gyanusitottsag = gyanusitottsag * (1 + b.Megbizhatosag/10);
			if (this.gyanusitottsag >= 80)
			{
				Console.WriteLine($"{this.gyanusSzemely.ToString()} elérte a küszöbértéket!");
			}
		}

		public int Gyanusitottsag { get => gyanusitottsag; set => gyanusitottsag = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Szemely GyanusSzemely { get => gyanusSzemely; set => gyanusSzemely = value; }

		public override string ToString()
		{
			return $"{this.gyanusSzemely.ToString()}\n\nGyanúsítottsági szint: {this.gyanusitottsag} - Státusz: {this.statusz}";
		}
	}
}
