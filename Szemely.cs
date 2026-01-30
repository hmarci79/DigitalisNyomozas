using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Szemely
	{
		private string nev;
		private int kor;
		private string megjegyzes;

		public Szemely(string nev, int kor, string megjegyzes)
		{
			this.nev = nev;
			this.kor = kor;
			this.megjegyzes = megjegyzes;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Kor { get => kor; set => kor = value; }
		public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }

		public override string ToString()
		{
			return $"{this.nev} ({this.kor}) - {this.megjegyzes}";
		}
	}
}
