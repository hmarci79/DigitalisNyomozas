using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Felhasznalo
	{
		private string nev;
		private int azonosito;
		private string szerepkor;

		public Felhasznalo(string nev, int azonosito, string szerepkor)
		{
			this.nev = nev;
			this.azonosito = azonosito;
			this.szerepkor = szerepkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Szerepkor { get => szerepkor; set => szerepkor = value; }

		public override string ToString()
		{
			return $"{this.nev}: {this.szerepkor} ({this.azonosito})";
		}
	}
}
