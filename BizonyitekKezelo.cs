using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class BizonyitekKezelo
	{
		private List<Bizonyitek> bizonyitekok;

		public BizonyitekKezelo()
		{
			this.bizonyitekok = new List<Bizonyitek>();
		}

		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

		public void Hozzaadas(Bizonyitek b)
		{
			if (this.bizonyitekok.Contains(b))
			{
				Console.WriteLine("Már van ilyen bizonyíték.");
			}
			else
			{
				Console.WriteLine("Sikeres hozzáadás!");
				this.bizonyitekok.Add(b);
			}
		}

		public void Torles(Bizonyitek b)
		{
			if (!this.bizonyitekok.Contains(b))
			{
				Console.WriteLine("Nincs ilyen bizonyíték a listában.");
			}
			else
			{
				Console.WriteLine("Sikeres törlés!");
				this.bizonyitekok.Remove(b);
			}
		}

		public override string ToString()
		{
			string s = "";
			foreach (var item in bizonyitekok)
			{
				s += item.ToString()+"\n";
			}
			return s;
		}
	}
}
