using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Idovonal
	{
		private string datum;
		private string leiras;

		public Idovonal(string datum, string leiras)
		{
			this.datum = datum;
			this.leiras = leiras;
		}

		public string Datum { get => datum; set => datum = value; }
		public string Leiras { get => leiras; set => leiras = value; }

		public override string ToString()
		{
			return $"{this.datum}: {this.leiras}";
		}
	}
}
