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

		public Adattar()
		{
			this.felhasznalok = new List<Felhasznalo>();
			this.ugyek = new List<Ugy>();
			this.szemelyek = new List<Szemely>();
			this.bizonyitekok = new List<Bizonyitek>();
		}

		internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
		internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }
		internal List<Szemely> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

		public override string ToString()
		{
			string s = "";
			s += "Felhasználók:\n";
			foreach (var item in felhasznalok)
			{
				s += "-"+item.ToString()+"\n";
			}
			s += "Ügyek:\n";
			foreach (var item in ugyek)
			{
				s += "-" + item.ToString() + "\n";
			}
			s += "Személyek:\n";
			foreach (var item in szemelyek)
			{
				s += "-" + item.ToString() + "\n";
			}
			s += "Bizonyítékok:\n";
			foreach (var item in bizonyitekok)
			{
				s += "-" + item.ToString() + "\n";
			}
			return s;
		}
	}
}
