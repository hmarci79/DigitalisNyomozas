using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Adattar
	{
		private List<Felhasznalo> felhasznalok;
		private List<Ugy> ugyek;
		private List<Szemely> szemelyek;
		private List<Bizonyitek> bizonyitekok;
		private List<Idovonal> esemenyek;

		public Adattar()
		{
			this.felhasznalok = new List<Felhasznalo>();
			this.ugyek = new List<Ugy>();
			this.szemelyek = new List<Szemely>();
			this.bizonyitekok = new List<Bizonyitek>();
			this.esemenyek = new List<Idovonal>();
		}

		internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
		internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }
		internal List<Szemely> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
		internal List<Idovonal> Esemenyek { get => esemenyek; set => esemenyek = value; }

		public string UgyKiiras()
		{
			string s = "";
			for (int i = 0; i < this.ugyek.Count(); i++)
			{
				s += (i+1) + ". " + this.ugyek[i].ToString() + "\n";
			}
			return s;
		}

		public string SzemelyKiiras()
		{
			string s = "";
			for (int i = 0; i < this.szemelyek.Count(); i++)
			{
				s += (i+1)+". "+this.szemelyek[i].ToString()+"\n";
			}
			return s;
		}

		public string BizonyitekKiiras()
		{
			string s = "";
			for (int i = 0; i < this.bizonyitekok.Count(); i++)
			{
				s += (i+1) + ". " + this.bizonyitekok[i].ToString() + "\n";
			}
			return s;
		}

		public string EsemenyekKiiras()
		{
			string s = "";
			for (int i = 0; i < this.esemenyek.Count(); i++)
			{
				s += (i + 1) + ". " + this.esemenyek[i].ToString() + "\n";
			}
			return s;
		}

		public List<Idovonal> IdovonalRendezes(List<Idovonal> eredeti)
		{
			List<Idovonal> rendezetlen = eredeti;
			List<Idovonal> rendezett = new List<Idovonal>();
			do
			{
				Idovonal min = new Idovonal(10000, 10000, 10000, "-");
				foreach (var item in rendezetlen)
				{
					if (item.Ev < min.Ev)
					{
						min = item;
					}
				}
				foreach (var item in rendezetlen)
				{
					if (min.Ev == item.Ev)
					{
						if (min.Honap > item.Honap)
						{
							min = item;
						}
						
					}
				}
				foreach (var item in rendezetlen)
				{
					if (min.Honap == item.Honap)
					{
						if (min.Nap > item.Nap)
						{
							min = item;
						}
					}
				}
				rendezett.Add(min);
				rendezetlen.Remove(min);
			}
			while (rendezetlen.Count() >= 1);
			
			return rendezett;
		}

		public override string ToString()
		{
			string s = "";
			s += "Felhasználók:\n";
			foreach (var item in this.felhasznalok)
			{
				s += "-"+item.ToString()+"\n";
			}
			s += "Ügyek:\n";
			foreach (var item in this.ugyek)
			{
				s += "-" + item.ToString() + "\n";
			}
			s += "Személyek:\n";
			foreach (var item in this.szemelyek)
			{
				s += "-" + item.ToString() + "\n";
			}
			s += "Bizonyítékok:\n";
			foreach (var item in this.bizonyitekok)
			{
				s += "-" + item.ToString() + "\n";
			}
			this.esemenyek = this.IdovonalRendezes(this.esemenyek);
			foreach (var item in this.esemenyek)
			{
				s += "-" + item.ToString() + "\n";
			}
			return s;
		}
	}
}
