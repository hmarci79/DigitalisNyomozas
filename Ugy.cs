using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Ugy
	{
		private int azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Szemely> ugyesSzemelyek;
		private List<Bizonyitek> ugyesBizonyitekok;
		private List<Idovonal> ugyesIdovonal;

		public Ugy(int azonosito, string cim, string leiras, string allapot)
		{
			this.azonosito = azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.ugyesSzemelyek = new List<Szemely>();
			this.ugyesBizonyitekok = new List<Bizonyitek>();
			this.ugyesIdovonal = new List<Idovonal>();
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Szemely> UgyesSzemelyek { get => ugyesSzemelyek; set => ugyesSzemelyek = value; }
		internal List<Bizonyitek> UgyesBizonyitekok { get => ugyesBizonyitekok; set => ugyesBizonyitekok = value; }
		internal List<Idovonal> UgyesIdovonal { get => ugyesIdovonal; set => ugyesIdovonal = value; }

		public void UgyAllapota(string ujStatusz)
		{
			this.allapot = ujStatusz;
		}

		public override string ToString()
		{
			string s = $"{this.cim} ({this.azonosito}/{this.allapot}): {this.leiras}\nSzemélyek:\n";
			foreach (var item in ugyesSzemelyek)
			{
				s += "-"+item.ToString()+"\n";
			}
			s += "Bizonyítékok:\n";
			foreach (var item in ugyesBizonyitekok)
			{
				s += "-"+item.ToString()+"\n";
			}
			s += "Idővonal:\n";
			if (this.ugyesIdovonal.Count() >= 2)
			{
				Adattar temp = new Adattar();
				this.UgyesIdovonal = temp.IdovonalRendezes(this.UgyesIdovonal);
			}
			foreach (var item in this.UgyesIdovonal)
			{
				s += "-" + item.ToString() + "\n";
			}
			return s;
		}
	}
}
