using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Tanu
	{
		private Szemely tanuSzemely;
		private string vallomas;
		private string datum;

		public Tanu(Szemely tanuSzemely, string vallomas, string datum)
		{
			this.tanuSzemely = tanuSzemely;
			this.vallomas = vallomas;
			this.datum = datum;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public string Datum { get => datum; set => datum = value; }
		internal Szemely TanuSzemely { get => tanuSzemely; set => tanuSzemely = value; }

		public override string ToString()
		{
			return $"{this.tanuSzemely.ToString()}\n\tVallomás: {this.vallomas} ({this.datum})";
		}
	}
}
